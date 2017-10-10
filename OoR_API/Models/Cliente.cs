using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OoR_API.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string cep { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public float saldo { get; set; }
    }
}