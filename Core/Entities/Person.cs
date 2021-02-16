namespace Core.Entities
{
    public class Person : Contact
    {
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public Person()
        {
        }
    }
}
