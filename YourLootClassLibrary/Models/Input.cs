using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("input")]
    public class Input
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el codigo del documento")]
        [Display(Name = "Codigo del documento de entrada")]
        public string CodeDocumentEntry { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion de la entrada")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Se requiere seleccionar el proveedor de la entrada")]
        [Display(Name = "Proveedor")]
        public int ProviderId { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el documento de la entrada")]
        [Display(Name = "Documento")]
        public int DocumentId { get; set; }

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

        [ForeignKey("ProviderId")]
        public virtual Provider Providers { get; set; }

    }
}
