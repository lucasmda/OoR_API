using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Context;
using OoR_API.Models;

namespace OoR_API
{
    public class DBInitializercs : DropCreateDatabaseAlways<Context.Context>
    {
        protected override void Seed(Context.Context context)
        {
            context.clientes.Add(new Cliente()
            {
                Id = 1,
                nome = "Lucas",
                senha = "test@123",
                cep = "098.94.596",
                telefone = "4399-1023",
                cpf = "234.312.345-31",
                dataNascimento = "27/06/1997",
                email = "lucas@fiap.com",
                saldo = 15.000f
            });

            context.clientes.Add(new Cliente()
            {
                Id = 2,
                nome = "Ivo",
                senha = "test@321",
                cep = "098.98.596",
                telefone = "4399-0923",
                cpf = "234.312.345-31",
                dataNascimento = "04/11/1990",
                email = "ivo@fiap.com",
                saldo = 16.000f
            });

            context.clientes.Add(new Cliente()
            {
                Id = 3,
                nome = "Nathali",
                senha = "123@test",
                cep = "123.98.596",
                telefone = "3212-0923",
                cpf = "234.312.345-31",
                dataNascimento = "06/12/1982",
                email = "nathalia@fiap.com",
                saldo = 17.000f
            });

            context.dividas.Add(new Divida()
            {
                Id = 1,
                ClienteId = 1,
                valor = 1550.00f,
                dataVencimento = "15/11/2017"
            });

            context.dividas.Add(new Divida()
            {
                Id = 2,
                ClienteId = 2,
                valor = 2000.00f,
                dataVencimento = "25/10/2017"
            });

            context.dividas.Add(new Divida()
            {
                Id = 3,
                ClienteId = 3,
                valor = 23455.00f,
                dataVencimento = "07/09/2017"
            });

            base.Seed(context);
        }
    }
}