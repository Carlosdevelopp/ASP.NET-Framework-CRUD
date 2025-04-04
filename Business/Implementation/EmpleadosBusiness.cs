using System.Collections.Generic;
using DataAccess.Implementation;
using DataAccess.Models.Tables;

namespace Business.Implementation
{
    public class EmpleadosBusiness
    {
        EmpleadosDataAccess empleadosData = new EmpleadosDataAccess();

        #region GET
        //Obtiene una lista de registros
        public List<Empleados> GetEmpleados()
        {
            List<Empleados>  empleadosList = empleadosData.GetEmpleados();
            return empleadosList;
        }
        #endregion
    }
}
