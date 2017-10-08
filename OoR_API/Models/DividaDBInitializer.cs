using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Context;
using OoR_API.Models;

namespace OoR_API.Models
{
    public class DividaDBInitializer : DropCreateDatabaseAlways<DividaContext>
    {
        protected override void Seed(DividaContext context)
        {
            context.dividas.Add(new Divida() {
                id_cliente = 1,
                valor = 1550.00f,
                dataVencimento = new DateTime(2017, 11, 02)
            });

            context.dividas.Add(new Divida()
            {
                id_cliente = 2,
                valor = 2000.00f,
                dataVencimento = new DateTime(2017, 10, 23)
            });

            context.dividas.Add(new Divida()
            {
                id_cliente = 3,
                valor = 23455.00f,
                dataVencimento = new DateTime(2017, 12, 27)
            });

            base.Seed(context);
        }
    }
}