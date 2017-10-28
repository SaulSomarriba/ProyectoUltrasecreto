using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("inputDetail")]
    public class InputDetail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el producto")]
        [Display(Name = "Producto")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Se requiere la cantidad de Producto")]
        [Display(Name = "Catidad de producto")]
        public int Quantity { get; set; }
                
        [Display(Name = "Entrada")]
        public int InputId { get; set; }

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

        [ForeignKey("InputId")]
        public virtual Input Inputs { get; set; }
    }
}
