using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Context;
using OoR_API.Models;

namespace OoR_API.Repositorio
{
    public class DividaRepositorio
    {
        private Context.Context _context;

        public DividaRepositorio()
        {
            _context = new Context.Context();
        }

        public IEnumerable<Divida> getDividas()
        {
            return _context.dividas;
        }

        public void updateDivida(Divida divida)
        {
            _context.Entry(divida).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}