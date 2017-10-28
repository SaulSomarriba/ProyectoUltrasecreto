using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("inventary")]
    public class Inventary
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el codigo del inventario")]
        [Display(Name = "Codigo del inventario")]
        public string CodeInventary { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion de la entrada")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el producto")]
        [Display(Name = "Producto")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Se requiere la cantidad del producto")]
        [Display(Name = "Cantidad de producto")]
        public string QuantityProduct { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateCreation { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateModification { get; set; }


        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }

    }
}

