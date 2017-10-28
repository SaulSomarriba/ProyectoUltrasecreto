using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("translation")]
    public class Translation
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion del traslado")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Se requiere el codigo del documento de movimiento")]
        [Display(Name = "Codigo del documento de movimiento")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Se requiere el motivo del movimiento")]
        [Display(Name = "Motivo del movimiento")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el documento")]
        [Display(Name = "Documento")]
        public int DocumentId { get; set; }

        [Required(ErrorMessage = "Se requiere la bodega de destino")]
        [Display(Name = "Bodega destino")]
        public int BatchDestiny { get; set; }

        [Required(ErrorMessage = "Se requiere la bodega de destino")]
        [Display(Name = "Bodega destino")]
        public int WarehouseDestiny { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateCreation { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateModification { get; set; }

        [ForeignKey("DocumentId")]
        public virtual Document Documents { get; set; }

    }
}
