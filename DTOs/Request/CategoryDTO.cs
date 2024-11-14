using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAppi.DTOs.Request
{
    public class CategoryDTO
    {
        [Required(ErrorMessage = "El Id de la categoria es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id de la categoria debe ser un número entero positivo mayor a 0.")]
        [Display(Name = "Id de la categoria")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre del producto no puede exceder los 50 caracteres.")]
        [Display(Name = "Nombre del producto")]
        public required string Name { get; set; }
    }
}