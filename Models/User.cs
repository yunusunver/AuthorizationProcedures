namespace authorizationProcedures.Models
{
    public class User{
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public int companyId  { get; set; }
        public string[] rightIds { get; set; }
    }
}