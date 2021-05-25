namespace AccessControlAdmin.Models
{

    public class RolesOfUser
    {
        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public string description { get; set; } = "";
        public string createdAt { get; set; } = "";
        public string updatedAt { get; set; } = "";
        public int user_roles_id { get; set; } = 0;
    }
}