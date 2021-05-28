namespace AccessControlAdmin.Models
{

    #nullable enable

    public class PermissionsOfRole
    {

        public int id { get; set; } = 0;
        public string name { get; set; } = "";

        public string suffix { get; set; } = "";
        public string description { get; set; } = "";
        public int? value_type_id { get; set; } = 0;
        public string? value_type_name { get; set; } = "";
        public string values { get; set; } = "";
        public string createdAt { get; set; } = "";
        public string updatedAt { get; set; } = "";
        public int role_permissions_id { get; set; } = 0;
    }
}