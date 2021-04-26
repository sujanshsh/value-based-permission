namespace AccessControlAdmin.Models
{

    public class User
    {

        public int id { get; set; } = 0;
        public string username { get; set; } = "";
        public string name { get; set; }
        public string role { get; set; } = "";
        public string password { get; set; } = "";
    }
}