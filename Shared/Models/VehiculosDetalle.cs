using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class VehiculosDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        [ForeignKey("Vehiculos")]
        public int VehiculoId { get;  set; }
        [ForeignKey("Accesorios")]
        public int AccesorioId { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        public double Valor { get; set; }
    }
}
