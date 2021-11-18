using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaServicios.Api.Libro.Aplicacion;

namespace TiendaServicios.Api.Libro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroMaterialController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LibroMaterialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            try
            {
                return await _mediator.Send(data);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<LibroMaterialDTO>>> GerLibros()
        {
            try
            {
                return await _mediator.Send(new Consulta.Ejecuta());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LibroMaterialDTO>> GerLibroUnico(Guid id)
        {
            try
            {
                return await _mediator.Send(new ConsultaFiltro.LibroUnico { LibroId = id });
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

    
}
