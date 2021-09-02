﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class HospedeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
