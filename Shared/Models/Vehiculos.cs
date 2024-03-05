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
        [Range(0.001, 1000000000 ,ErrorMessage ="El rango debe estar entra 0.001 a 1000000000")]
        public double Costo { get; set; }
        [Required(ErrorMessage = "Este campo es requrido")]
        public double Gastos { get; set; }

        [ForeignKey("VehiculoId")]
        public ICollection<VehiculosDetalle?> VehiculosDetalles = new List<VehiculosDetalle?>();
    }
}
