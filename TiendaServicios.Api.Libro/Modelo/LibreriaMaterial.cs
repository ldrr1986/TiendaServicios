using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.Libro.Modelo
{
    public class LibreriaMaterial
    {
        public Guid? LibreriaMaterialId { set; get; }
        public string Titulo { set; get; }
        public DateTime? FechaPublicacion { set; get; }
        public Guid? AutorLibro { set; get; }
    }
}
