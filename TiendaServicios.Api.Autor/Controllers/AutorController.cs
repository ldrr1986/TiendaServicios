using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaServicios.Api.Autor.Aplicacion;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AutorController(IMediator mediator)
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
        //public async Task<ActionResult<List<AutorLibro>>> GerAutores()
        public async Task<ActionResult<List<AutorDto>>> GerAutores()
        {
            try
            {
                return await _mediator.Send(new Consulta.ListaAutor());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        //public async Task<ActionResult<AutorLibro>> GerAutorLibro(string id)
        public async Task<ActionResult<AutorDto>> GerAutorLibro(string id)
        {
            try
            {
                return await _mediator.Send(new ConsultaFiltro.AutorUnico{ AutoGuid = id});
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
