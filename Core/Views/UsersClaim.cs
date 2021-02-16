namespace Core.Entities
{
    public class UsersClaim
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}
