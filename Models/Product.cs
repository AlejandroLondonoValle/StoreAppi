using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAppi.Models;

[Table("products")]
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("price")]
    public double Price { get; set; }

    [Column("cost")]
    public double Cost { get; set; }

    [Column("category_id")]
    public int Category_id { get; set; }

    [ForeignKey("Category_id")]
    public Category? Category { get; set; }


    
    public Product()
    {

    }

}
