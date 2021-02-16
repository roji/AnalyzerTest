namespace Core.Entities
{
   public class TicketUser
   {
      public int Id { get; set; }
      public string FullName { get; set; }
      public string NationalCode { get; set; }
      public string Email { get; set; }
      public string Address { get; set; }
      public string Mobile { get; set; }
      public virtual User User { get; set; }
      public int? UserId { get; set; }
      public virtual Ticket Ticket { get; set; }
      public int TicketId { get; set; }
   }
}
