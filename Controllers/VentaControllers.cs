using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVideojuegos.DataAccess;
using TiendaVideojuegos.Model;

namespace TiendaVideojuegos.Controllers
{
    internal class VentaControllers
    {
        private readonly VentaDAO ventaDAO;

        public VentaControllers(string connectionString)
        {
            ventaDAO = new VentaDAO(connectionString);
        }

        public bool AgregarNuevoVenta(Venta venta)
        {
            return ventaDAO.AgregarVenta(venta);
        }
    }
}
