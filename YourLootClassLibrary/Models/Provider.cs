using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("provider")]
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del proveedor")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Se requiere la descripcion del proveedor")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Se requiere la direccion del proveedor")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }
        

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateCreation { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateModification { get; set; }
        
    }
}
