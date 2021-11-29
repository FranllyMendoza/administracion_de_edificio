using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracion_de_edificio.Entidades
{
    class Facturar
    {
        [Key]
        public int IdFactura { get; set; }
        public string Nombre { get; set; }
        public string  Monto { get; set; }
        public DateTime Fecha_pago { get; set; } = DateTime.Now;


    }
}
