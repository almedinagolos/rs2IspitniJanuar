using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Database;
using eProdaja.Model.Requests;
using eProdaja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class PregledNarudzbiController : ControllerBase
    {
        private readonly IPregledNarudzbiService _service;

        public PregledNarudzbiController(IPregledNarudzbiService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.PregledNarudzbi> GetAll([FromQuery] PregledNarudzbiSearchRequest request)
        {
            return _service.GetAll(request);
        }
        [Authorize]
        [HttpPost]
        public Model.PregledNarudzbi Insert(PregledNarudzbiInsertRequest pregledNarudzbi)
        {
            return _service.Insert(pregledNarudzbi);
        }

       
    }
}
