using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class ReservaModel
    {
        public int Id { get; set; }
        public HospedeModel Hospede { get; set; }
        public QuartoModel Quarto { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtSaida { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int TipoPagamento { get; set; }
        public double Total { get; set; }
        public int QtdAcompanhante { get; set; }
    }
}
