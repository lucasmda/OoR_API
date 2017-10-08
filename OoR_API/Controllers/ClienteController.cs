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
    public class ClienteController : ApiController
    {
        private ClienteRepositorio db = new ClienteRepositorio();

        // GET: api/Cliente
        public IEnumerable<Cliente> Get()
        {
            return db.getClientes();
        }

        // GET: api/Cliente/5
        public Cliente Get(int id)
        {
            return db.getClienteById(id);
        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
