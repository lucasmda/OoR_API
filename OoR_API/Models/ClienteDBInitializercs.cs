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
                dataNascimento = "27/06/1997",
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
                dataNascimento = "04/11/1990",
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
                dataNascimento = "06/12/1982",
                email = "nathalia@fiap.com",
                saldo = 17.000f
            });

            base.Seed(context);
        }
    }
}