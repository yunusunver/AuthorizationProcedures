namespace authorizationProcedures.Models
{
    public class Company
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string officialName { get; set; }
        public bool isDeleted { get; set; }
    }
}