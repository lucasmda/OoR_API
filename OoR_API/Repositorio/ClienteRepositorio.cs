using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Context;
using OoR_API.Models;

namespace OoR_API.Repositorio
{
    public class ClienteRepositorio
    {
        private ClienteContext _context;

        public ClienteRepositorio()
        {
            _context = new ClienteContext();
        }

        public IEnumerable<Cliente> getClientes()
        {
            return _context.clientes;
        }

        public Cliente getClienteById(int id)
        {
            return _context.clientes.Find(id);
        }
    }
}