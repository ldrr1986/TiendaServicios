using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.CarritoCompra.Aplicacion
{
    public class CarritoDTO
    {
        public int CarritoID { get; set; }
        public DateTime? FechaCreacionSesion { get; set; }

        public List<CarritoDetalleDTO> ListaProductos { get; set; }

    }
}
