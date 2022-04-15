namespace api.models
{
    public class Store
    {
        public int id { get; set; }
        public string addressLineOne { get; set; }
        public string addressLineTwo { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
    }
}