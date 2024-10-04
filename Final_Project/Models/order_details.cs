using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class order_details
    {

        [ForeignKey("order")]
        public int order_id { get; set; }
        [ForeignKey("products")]
        public int product_id { get; set; }
        public int price { get; set; }
        public string sku { get; set; }
        public int quantity { get; set; }


        public products products { get; set; }
        public orders order { get; set; }
    }
}
