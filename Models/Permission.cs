namespace AccessControlAdmin.Models
{

    public class Permission
    {

        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public string description { get; set; } = "";
        public string values { get; set; } = "";
        public string createdAt { get; set; } = "";
        public string updatedAt { get; set; } = "";
    }
}