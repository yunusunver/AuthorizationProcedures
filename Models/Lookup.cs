namespace authorizationProcedures.Models
{
    public class Lookup
    {
        public int id { get; set; }     
        public string type { get; set; }
        public string name { get; set; } 
        public int orderBy { get; set; }
        public string description { get; set; }
        public int parentId { get; set; }
             
    }
}