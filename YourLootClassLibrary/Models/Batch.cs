using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourLootClassLibrary.Models
{
    [Table("batch")]
    public class Batch
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del lote")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Se requiere la descripcion del lote")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Se requiere seleccionar la bodega")]
        [Display(Name = "Bodega")]
        public int WarehouseId { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateCreation { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateModification { get; set; }

        [ForeignKey("WarehouseId")]
        public virtual Warehouse Warehouses { get; set; }
    }
}
