using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class orders
    {
        public int Id { get; set; }
        [ForeignKey("customer")]
        public int customer_id { get; set; }
        public int amount { get; set;}
        public string shipping_address { get; set; }
        public string orders_address { get; set; }
        public string orders_email { get; set; }
        public DateOnly orders_date { get; set; }
        public string orders_status { get; set; }
        public virtual List<order_details>order_detail {  get; set; }
        public customers customer { get; set; }

    }
}
