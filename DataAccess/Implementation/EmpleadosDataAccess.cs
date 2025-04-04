using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Models.Tables;

namespace DataAccess.Implementation
{
    public class EmpleadosDataAccess
    {
        //private string cadena = ConfigurationManager.ConnectionStrings["conexionEmpleados"].ConnectionString;

        #region GET
        //Método para obtener una lista de registros
        public List<Empleados> GetEmpleados()
        {
            List<Empleados> listEmpleados = new List<Empleados>();

            string cadena = "server=localhost\\SQLEXPRESS; database=EmpleadosDB; user=sa; password=DBForge2025; Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            SqlCommand comand = new SqlCommand("sp_ObtenerEmpleados", conexion);
            comand.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader  = comand.ExecuteReader();

            while (reader.Read())
            {
                Empleados empleados = new Empleados();
                empleados.Nombre = Convert.ToString(reader["Nombre"]);
                empleados.ApellidoPaterno = Convert.ToString(reader["ApellidoPaterno"]);
                empleados.ApellidoMaterno = Convert.ToString(reader["ApellidoMaterno"]);
                empleados.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                empleados.FechaContratacion = Convert.ToDateTime(reader["FechaContratacion"]);
                empleados.Telefono = Convert.ToString(reader["Telefono"]);
                empleados.Correo = Convert.ToString(reader["Correo"]);
                empleados.Estado = Convert.ToBoolean(reader["Estado"]);
                empleados.DepartamentoId = Convert.ToInt32(reader["DepartamentoId"]);
                empleados.CargoId = Convert.ToInt32(reader["CargoId"]);
                listEmpleados.Add(empleados);
            }

            conexion.Close();
            return listEmpleados;
        }
        #endregion

    }
}
