using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public int Nivel { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int Status { get; set; }
    }
}
