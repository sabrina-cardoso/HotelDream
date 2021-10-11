using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class AcompanhanteModel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ReservaModel Reserva { get; set; }
    }
}
