using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    public class DetalleControllers
    {
        private readonly DetalleDAO detalleDAO;

        public DetalleControllers(string connectionString)
        {
            detalleDAO = new DetalleDAO(connectionString);
        }

        public bool AgregarNuevoDetalle(Detalle detalle)
        {
            return detalleDAO.AgregarDetalle(detalle);
        }
    }
}
