using System;

namespace DataAccess.Models.Tables
{
    public class Empleados
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Telefono { get; set; }    
        public string Correo { get; set; }    
        public string Cargo { get; set; }    
        public bool Estado { get; set; }    
        public int CargoId { get; set; }
        public int DepartamentoId { get; set; }
    }
}
