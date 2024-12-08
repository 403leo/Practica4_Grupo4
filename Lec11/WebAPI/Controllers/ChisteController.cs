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
    public class ChisteController : ApiController
    {
        private readonly IChisteService _chisteService;        

        public ChisteController(IChisteService chisteService)
        {
            _chisteService = chisteService;
        }

        [HttpGet]
        public IEnumerable<Chiste> GetAll()
        {
            return _chisteService.GetChistes();
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var chiste = _chisteService.GetById(id);
            if(chiste == null)
            {
                return NotFound();
            }
            return Ok(chiste);
        }

        [HttpPost]
        public IHttpActionResult Add(Chiste chiste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _chisteService.CreateChiste(chiste);
            return Ok(chiste);
        }

        [HttpPut]
        public IHttpActionResult Update(Chiste chiste)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _chisteService.UpdateChiste(chiste);
            return Ok(chiste);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _chisteService.DeleteChiste(id);
            return Ok();
        }

    }
}
