using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("translationtDetail")]
    public class TranslationDetail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion del producto")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el producto")]
        [Display(Name = "producto")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Se requiere la cantidad de producto")]
        [Display(Name = "Cantidad producto")]
        public int quantity { get; set; }

        [Required(ErrorMessage = "Se requiere la bodega de destino")]
        [Display(Name = "Bodega destino")]
        public int warehouseDestiny { get; set; }

        [Display(Name = "Traslado")]
        public int TraslationId { get; set; }        

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateCreation { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateModification { get; set; }

        [ForeignKey("TraslationId")]
        public virtual Translation Translations { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Products { get; set; }
    }
}
