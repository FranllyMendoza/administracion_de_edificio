using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace administracion_de_edificio.Entidades
{
    class Clientes
    {
        [Key]
        public int IDcliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Telefono2 { get; set; }
        public string Correo { get; set; }
        public string Piso { get; set; }
        public string  Apartamento { get; set; }
        public string  Parqueo { get; set; }
        public string  Nombre_referencia { get; set; }
        public string Numero_referencia { get; set; }
        public DateTime Fecha_registro { get; set; } = DateTime.Now;


    }
}
