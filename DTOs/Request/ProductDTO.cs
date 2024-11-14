using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAppi.DTOs.Request;

public class ProductDTO
{
    [Required(ErrorMessage = "El Id del producto es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id del producto debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id del producto")]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre del producto no puede exceder los 50 caracteres.")]
    [Display(Name = "Nombre del producto")]
    public required string Name { get; set; }


    [Required(ErrorMessage = "El precio es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser un número positivo mayor o igual a 0.")]
    [Display(Name = "Precio")]
    public double Price { get; set; }


    [Required(ErrorMessage = "El costo es requerido.")]
    [Range(0, double.MaxValue, ErrorMessage = "El costo debe ser un número positivo mayor o igual a 0.")]
    [Display(Name = "Costo")]
    public double Cost { get; set; }


    [Required(ErrorMessage = "El Id de la categoria es requerido.")]
    [Range(1, int.MaxValue, ErrorMessage = "El Id de la categoria debe ser un número entero positivo mayor a 0.")]
    [Display(Name = "Id de la categoria")]
    public int Category_id { get; set; }

}
