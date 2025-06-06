using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    public class EmpleadoControllers
    {
        private readonly EmpleadoDAO empleadoDAO;

        public EmpleadoControllers(string connectionString)
        {
            empleadoDAO = new EmpleadoDAO(connectionString);
        }

        public bool AgregarNuevoEmpleado(Empleado empleado)
        {
            return empleadoDAO.AgregarEmpleado(empleado);
        }
    }
}
