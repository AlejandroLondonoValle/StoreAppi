using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAppi.DTOs.Request
{
    public class OrderDTO
    {
        [Required(ErrorMessage = "El Id de la orden es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id de la orden debe ser un número entero positivo mayor a 0.")]
        [Display(Name = "Id de la orden")]
        public int Id { get; set; }

        [Required(ErrorMessage = "La descripcion de la orden es obligatorio.")]
        [StringLength(250, ErrorMessage = "La descripcion de la orden no puede exceder los 250 caracteres.")]
        [Display(Name = "descripcion de la orden")]
        public required string Description { get; set; }
    }
}