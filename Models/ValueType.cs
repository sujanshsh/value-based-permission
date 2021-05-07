namespace AccessControlAdmin.Models
{

    public class ValueType
    {

        public int id { get; set; } = 0;
        public string name { get; set; } = "";
        public string description { get; set; } = "";
        public string URL { get; set; } = "";
        public int refreshIntervalMinutes { get; set; } = 0;
        public string refreshTriggerEventTopic { get; set; } = "";
        public bool refreshTriggerEnable { get; set; } = false;
    }
}