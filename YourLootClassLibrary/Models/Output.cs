using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("output")]
    public class Output
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el codigo del documento")]
        [Display(Name = "Codigo del documento de salida")]
        public string CodeDocumentOutput { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion de la salida")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el cliente de la salida")]
        [Display(Name = "Cliente")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar el documento de la salida")]
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

        [ForeignKey("ClientId")]
        public virtual Client Clients { get; set; }

        [ForeignKey("DocumentId")]
        public virtual Document Documents { get; set; }
    }
}
