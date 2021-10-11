using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class AvaliacaoModel
    {
        public int Id { get; set; }
        public DateTime DtAvaliacao { get; set; }
        public int NotaAtendimento { get; set; }
        public int NotaAcomodacao { get; set; }
        public int NotaRecomendacao { get; set; }
        public string Observacao { get; set; }
    }
}
