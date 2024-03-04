using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        [Required(ErrorMessage ="Este campo es requrido")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo es requrido")]
        public DateTime? Fecha { get; set; }
        [Required(ErrorMessage = "Este campo es requrido")]
        public double Gastos { get; set; }

        [ForeignKey("VehiculoId")]
        public ICollection<VehiculosDetalle?> VehiculosDetalles = new List<VehiculosDetalle?>();
    }
}
