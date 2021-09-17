using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Categoria { get; set; }
        public int Disponivel { get; set; }
        public string Descricao { get; set; }
    }
}
