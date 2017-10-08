using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OoR_API.Repositorio;
using OoR_API.Models;

namespace OoR_API.Controllers
{
    public class DividaController : ApiController
    {
        private DividaRepositorio db = new DividaRepositorio();

        // GET: api/Divida
        public IEnumerable<Divida> Get()
        {
            return db.getDividas();
        }

        // GET: api/Divida/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Divida
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Divida/5
        public void Put(int id, [FromBody]Divida value)
        {
            db.updateDivida(value);
        }

        // DELETE: api/Divida/5
        public void Delete(int id)
        {
        }
    }
}
