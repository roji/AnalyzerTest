using System;
using System.Linq.Expressions;

namespace Core.Tools
{
   public static class ExpressionCombineExtentions {

      public static Expression<Func<TOutput, TReturn>> Cast<TOutput, TInput, TReturn> (this Expression<Func<TOutput, TInput>> source) =>
          Expression.Lambda<Func<TOutput, TReturn>> (source.Body, source.Parameters);
      

      public static Expression<Func<B, bool>> Attach<A, B> (this Expression<Func<A, bool>> expr, Expression<Func<B, A>> selector) {
         Expression<Func<B, bool>> left = _ => true;
         return left.Combine (CombineModes.And, expr, selector);
      }

      public static Expression<Func<T, bool>> Combine<T> (this Expression<Func<T, bool>> expr1, CombineModes combineMode , Expression<Func<T, bool>> expr2  ) {
         var replaceParameter = expr1.Parameters[0];
         var left = expr1.Body;
         var rightVisitor = new ReplaceExpVisitor (replaceParameter);
         var right = rightVisitor.Visit (expr2.Body);
         // creating new expression and pass (q) reference to it (replaceParameter).
         return combineMode
         switch {
            CombineModes.And => Expression.Lambda<Func<T, bool>> (Expression.AndAlso (left, right), replaceParameter),
               CombineModes.Or => Expression.Lambda<Func<T, bool>> (Expression.OrElse (left, right), replaceParameter),
               _ =>
               throw new NotImplementedException (combineMode.ToString ())
         };
      }
      public static Expression<Func<B, bool>> Combine<B, A> (this Expression<Func<B, bool>> expr1, CombineModes combineMode,Expression<Func<A, bool>> expr2, Expression<Func<B, A>> selector) {
         // this is (q) parameter of my selector 
         var replaceParameter = selector.Parameters[0];

         // replacing all (b) parameters with the (q)
         // these two lines convert `b => b.Id == 100` to `q => q.Id == 100` 
         // using ReplaceExpVisitor class
         var leftVisitor = new ReplaceExpVisitor (replaceParameter);
         var left = leftVisitor.Visit (expr1.Body);

         // the property body is 'q.objectA'
         var replaceBody = selector.Body;

         // replacing every (a) parameter of my second expression to 'q.objectA'
         // these two lines convert this statement:
         // 	 a.Id > 1 && a.address.city == "city1" || a.address.country == "us"
         // to this :
         //   q.objectA.Id > 1 && q.objectA.address.city == "city1" || q.objectA.address.country == "us"
         var rightVisitor = new ReplaceExpVisitor (replaceBody);
         var right = rightVisitor.Visit (expr2.Body);

         // creating new expression and pass (q) reference to it (replaceParameter).
         return combineMode switch 
         {
            CombineModes.And => Expression.Lambda<Func<B, bool>> (Expression.AndAlso (left, right), replaceParameter),
            CombineModes.Or => Expression.Lambda<Func<B, bool>> (Expression.OrElse (left, right), replaceParameter),
            _ => throw new NotImplementedException (combineMode.ToString ())
         };

      }

      // this is a simple class to replace all parameters with new expression
      private class ReplaceExpVisitor : ExpressionVisitor {
         private readonly Expression _newval;
         public ReplaceExpVisitor (Expression newval) => _newval = newval;
         protected override Expression VisitParameter (ParameterExpression node) => _newval;        
      }

   }
   public enum CombineModes {
      And,
      Or
   }
}
