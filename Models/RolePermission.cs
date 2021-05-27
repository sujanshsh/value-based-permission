namespace AccessControlAdmin.Models
{

    public class RolePermission
    {
        public int id { get; set; } = 0;
        public int role_id { get; set; } = 0;
        public int permission_id { get; set; } = 0;
    }
}