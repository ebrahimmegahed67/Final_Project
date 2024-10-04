namespace Final_Project.Models
{
    public class customers
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string billing_address { get; set; }
        public string default_shipping_address { get; set; }
        public string country { get; set; }
        public int phone { get; set; }
        public virtual List<orders> order {  get; set; }
    }
}
