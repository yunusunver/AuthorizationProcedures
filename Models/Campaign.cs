using System;
namespace authorizationProcedures.Models
{
    public class Campaign
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public string endDate { get; set; }
        public bool isDeleted  { get; set; }
        public bool isActive { get; set; }
        public int campaignId  { get; set; }
        public int createdBy { get; set; }
        public int  updatedBy { get; set; }
        public DateTime createdDate { get; set; }
    }
}