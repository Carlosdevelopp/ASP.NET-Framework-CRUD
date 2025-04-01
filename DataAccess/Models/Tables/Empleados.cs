using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Tables
{
    public class Empleados
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public int Edad {  get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaContratacion { get; set; }
        public string Telefono { get; set; }    
        public string Correo { get; set; }    
        public string Cargo { get; set; }    
        public string Estado { get; set; }    
    }
}
