using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAppi.DTOs.Request
{
    public class OrderProductDTO
    {
        [Required(ErrorMessage = "El Id del producto es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id del producto debe ser un número entero positivo mayor a 0.")]
        [Display(Name = "Id del producto")]
        public int Id { get; set; }


        [Required(ErrorMessage = "La cantidad es requerida.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser un número entero positivo mayor a 0.")]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }


        [Required(ErrorMessage = "El Id del producto es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id del producto debe ser un número entero positivo mayor a 0.")]
        [Display(Name = "Id del producto")]
        public int Product_id { get; set; }


        [Required(ErrorMessage = "El Id de la orden es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El Id de la orden debe ser un número entero positivo mayor a 0.")]
        [Display(Name = "Id de la orden")]
        public int Order_id { get; set; }
    }
}