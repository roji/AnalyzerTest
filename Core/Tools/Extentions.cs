using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using DNTPersianUtils.Core;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Core.Tools
{
   public static class Extentions
   {

#region "DateTime"
      public static int ToShamsiInt(this DateTime dateTime) =>
         Convert.ToInt32(dateTime.ToShortPersianDateString(true).Replace("/", ""));

      public static DateTime ToMiladiDateTime(this int shamsiDate) => ToMiladiDateTime(shamsiDate.ToString());
      public static DateTime ToMiladiDateTime(this string shamsiDate)
      {
         try
         {
            var pCal = new PersianCalendar();
            return pCal.ToDateTime(Strings.Left(shamsiDate, 4).ToInt(), shamsiDate.Substring(4, 2).ToInt(), Strings.Right(shamsiDate, 2).ToInt(), 0, 0, 0, 0, 1);
         }
         catch (Exception ex)
         {
            throw new Exception("input argument is not a valid shamsi date", ex);
         }

      }

      public static int ToInt(this string stringNumber)
      {
         try
         {
            return Convert.ToInt32(stringNumber);
         }
         catch (Exception ex)
         {
            throw new Exception("input argument is not a valid int", ex);
         }

      }
#endregion

      public static string FormatShamsiIntWithSlashes(this int shamsiInt) =>
         $"{shamsiInt.ToString().Substring(0, 4)}/{shamsiInt.ToString().Substring(4, 2)}/{shamsiInt.ToString().Substring(6, 2)}";

      public static string FormatShamsiIntWithSlashes(this DateTime dateTime) =>
         dateTime.ToShortPersianDateString(true);

      public static string setDefault<T>(this T? value, string defaultValue = "null") where T : struct => value?.ToString() ?? defaultValue;

      public static string SetDefaultNullString<T>(this T? value) where T : struct => value?.ToString() ?? "null";

      public static bool None<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) => !source.Any(predicate);

      public static string Right(this string value, int length) => value.Substring(value.Length - length);

      public static T DeepClone<T>(this T obj)
      {
         using(var ms = new MemoryStream())
         {
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            ms.Position = 0;

            return (T) formatter.Deserialize(ms);
         }
      }

      /// <summary>
      /// Gets an attribute on an enum field value
      /// </summary>
      /// <typeparam name="T">The type of the attribute you want to retrieve</typeparam>
      /// <param name="enumVal">The enum value</param>
      /// <returns>The attribute of type T that exists on the enum value</returns>
      /// <example>string desc = myEnumVariable.GetAttributeOfType<DescriptionAttribute>().Description;</example>
      public static T GetAttributeOfType<T>(this Enum enumVal) where T : System.Attribute
      {
         if (enumVal == null) return null;
         var type = enumVal.GetType();
         var memInfo = type.GetMember(enumVal.ToString());
         if (memInfo.Count() == 0) return null;
         var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
         return (attributes.Length > 0) ? (T) attributes[0] : null;
      }

      public static string GetDisplayNameAttribute(this Enum enumVal)
      {
         if (enumVal == null) return "نامشخص";
         var type = enumVal.GetType();
         var memInfo = type.GetMember(enumVal.ToString());
         if (memInfo.Count() == 0) return "نامشخص";
         var attributes = memInfo[0].GetCustomAttributes(typeof(DisplayAttribute), false);
         return (attributes.Length > 0) ? ((DisplayAttribute) attributes[0]).Name : "نامشخص";
      }

      public static TimeSpan MeasureExecutionTime(Action act, string actName = "noName", bool autoLog = true)
      {
         Stopwatch sw = new Stopwatch();
         sw.Start();
         act();
         sw.Stop();
         if (autoLog)
         {
            Console.WriteLine($"#####-------------------------------------#####");
            Console.WriteLine($"#####--- The {actName} action executed in {sw.ElapsedMilliseconds}ms. ---#####");
         }
         return sw.Elapsed;
      }

      public static int GetEnumLength<T>() where T : struct, IConvertible
      {
         if (!typeof(T).IsEnum)
            throw new ArgumentException("T must be an enumerated type");
         return Enum.GetNames(typeof(T)).Length;
      }
   }
}
