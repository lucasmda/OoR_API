using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_API.Context;
using OoR_API.Models;

namespace OoR_API
{
    public class ClienteDBInitializercs : DropCreateDatabaseAlways<ClienteContext>
    {
        protected override void Seed(ClienteContext context)
        {
            context.clientes.Add(new Cliente()
            {
                nome = "Lucas",
                senha = "test@123",
                cep = "098.94.596",
                telefone = "4399-1023",
                cpf = "234.312.345-31",
                dataNascimento = new DateTime(1997, 06, 27),
                email = "lucas@fiap.com",
                saldo = 15.000f
            });

            context.clientes.Add(new Cliente()
            {
                nome = "Ivo",
                senha = "test@321",
                cep = "098.98.596",
                telefone = "4399-0923",
                cpf = "234.312.345-31",
                dataNascimento = new DateTime(1995, 09, 25),
                email = "ivo@fiap.com",
                saldo = 16.000f
            });

            context.clientes.Add(new Cliente()
            {
                nome = "Nathali",
                senha = "123@test",
                cep = "123.98.596",
                telefone = "3212-0923",
                cpf = "234.312.345-31",
                dataNascimento = new DateTime(1990, 12, 12),
                email = "nathalia@fiap.com",
                saldo = 17.000f
            });

            base.Seed(context);
        }
    }
}