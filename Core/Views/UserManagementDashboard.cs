namespace Core.Entities
{
    public class UserManagementDashboard
    {
        public string Province { get; set; }
        public int ActiveUsers { get; set; }
        public int DeactiveUsers { get; set; }
        public int TotalUsers
        {
            get
            {
                return (ActiveUsers + DeactiveUsers);
            }
        }
    }
}
