using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("warehouse")]
    public class Warehouse
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere nombre de la bodega")]
        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Se requiere la ubicacion de la bodega")]
        [Display(Name = "Ubicacion")]
        public int Ubication { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion de la bodega")]
        [Display(Name = "Descripcion")]
        public int Description { get; set; }

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
