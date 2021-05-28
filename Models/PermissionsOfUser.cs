namespace AccessControlAdmin.Models
{

    #nullable enable
    public class PermissionsOfUser
    {

        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public string suffix { get; set; } = "";
        public string description { get; set; } = "";
        public int? value_type_id { get; set; } = 0;
        public string values { get; set; } = "";
        public string createdAt { get; set; } = "";
        public string updatedAt { get; set; } = "";
        public int role_id { get; set; } = 0;
        public string role_name { get; set; } = "";
        public string? value_type_name { get; set; } = "";
    }
}