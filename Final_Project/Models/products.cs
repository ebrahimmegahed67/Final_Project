namespace Final_Project.Models
{
    public class products
    {
        public int id { get; set; }
        public string sku { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int weight { get; set; }
        public string description { get; set; }
        public string? image { get; set; }
        public string catgory { get; set; }
        public DateOnly date {  get; set; }
        public int stock { get; set; }
       
        public virtual List<product_category> product_category { get; set; }
        public virtual List<order_details> order_details { get; set; }
    }
}
