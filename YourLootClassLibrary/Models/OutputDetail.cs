using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("outputDetail")]
    public class OutputDetail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere especificar el producto")]
        [Display(Name = "Producto")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Se requiere la cantidad de Producto")]
        [Display(Name = "Catidad de producto")]
        public int quantity { get; set; }

        [Display(Name = "Salida")]
        public int OutputId { get; set; }

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

        [ForeignKey("OutputId")]
        public virtual Output Outputs { get; set; }
    }
}
