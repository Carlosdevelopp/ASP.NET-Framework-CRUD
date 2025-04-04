using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Business.Implementation;
using DataAccess.Models.Tables;

namespace EmpleadoManager.Controllers
{
    public class EmpleadosController : Controller
    {
		EmpleadosBusiness empleadosList = new EmpleadosBusiness();

        // GET: Empleados
        public ActionResult Index()
		{
			try
			{
				List<Empleados> listEmpleados = empleadosList.GetEmpleados();
				return View("Index",listEmpleados);
			}
			catch (Exception ex)
			{
				TempData["error"] = $"{ex.Message}";
				return View("Index");
			}
        }
    }
}