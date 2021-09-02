using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    class UsuarioModel
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
