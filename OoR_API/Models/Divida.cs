﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OoR_API.Models
{
    public class Divida
    {
        public int id { get; set; }
        public float valor { get; set; }
        public DateTime dataVencimento { get; set; }
        public int id_cliente { get; set; }
        public virtual Cliente cliente { get; set; }
    }
}