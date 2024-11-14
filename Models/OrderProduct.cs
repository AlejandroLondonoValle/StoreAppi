using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StoreAppi.Models;
using System.Threading.Tasks;

namespace StoreAppi.Models;


[Table("order_products")]
public class OrderProduct
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("quantity")]
    public int Quantity  { get; set; }

    [Column("product_id")]
    public int Product_id { get; set; }

    [Column("order_id")]
    public int Order_id { get; set; }

    [ForeignKey("Product_id")]
    public Product? Product { get; set; }

    [ForeignKey("Order_id")]
    public Order? Order { get; set; }


    public OrderProduct()
    {
        
    }
}
