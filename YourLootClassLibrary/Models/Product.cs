using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del producto")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre completo del Producto")]
        [Display(Name = "Nombre completo")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion del producto")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Se requiere el costo del producto")]
        [Display(Name = "cost")]
        public float Cost { get; set; }

        [Required(ErrorMessage = "Se requiere el precio de venta del producto")]
        [Display(Name = "PrecioVenta")]
        public float SellPrice { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el lote del producto")]
        [Display(Name = "Lote")]
        public int BatchId { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateCreation { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateModification { get; set; }


        [ForeignKey("BatchId")]
        public virtual Batch Batchs { get; set; }

    }
}
