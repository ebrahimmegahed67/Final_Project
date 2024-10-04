using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class product_category
    {
        //[Key]
        //public int Id { get; set; }


        [ForeignKey("products")]
        public int product_id {  get; set; }

        [ForeignKey("categories")]
        public int category_id {  get; set; } 
        public products products { get; set; }
        public categories categories { get; set; }
    }

}
