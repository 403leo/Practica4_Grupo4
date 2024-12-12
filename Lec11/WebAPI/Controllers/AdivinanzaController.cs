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
    public class AdivinanzaController : ApiController
    {
        private readonly IAdivinanzaService _adivinanzaService;

        public AdivinanzaController(IAdivinanzaService adivinanzaService)
        {
            _adivinanzaService = adivinanzaService;
        }

        [HttpGet]
        public IEnumerable<Adivinanza> GetAll()
        {
            return _adivinanzaService.GetAdivinanzas();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var adivinanza = _adivinanzaService.GetById(id);
            if (adivinanza == null)
            {
                return NotFound();
            }
            return Ok(adivinanza);
        }

        [HttpPost]
        public IHttpActionResult Add(Adivinanza adivinanza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _adivinanzaService.CreateAdivinanza(adivinanza);
            return Ok(adivinanza);
        }

        [HttpPut]
        public IHttpActionResult Update(Adivinanza adivinanza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _adivinanzaService.UpdateAdivinanza(adivinanza);
            return Ok(adivinanza);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _adivinanzaService.DeleteAdivinanza(id);
            return Ok();
        }
    }
}