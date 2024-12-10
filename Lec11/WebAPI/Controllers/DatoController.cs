using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DatoController : ApiController
    {
        private readonly IDatoService _datoService;

        public DatoController(IDatoService datoService)
        {
            _datoService = datoService;
        }

        [HttpGet]
        public IEnumerable<Dato> GetAll()
        {
            return _datoService.GetDatos();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var dato = _datoService.GetById(id);
            if (dato == null)
            {
                return NotFound();
            }
            return Ok(dato);
        }

        [HttpPost]
        public IHttpActionResult Add(Dato dato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _datoService.CreateDato(dato);
            return Ok(dato);
        }

        [HttpPut]
        public IHttpActionResult Update(Dato dato)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _datoService.UpdateDato(dato);
            return Ok(dato);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _datoService.DeleteDato(id);
            return Ok();
        }
    }
}