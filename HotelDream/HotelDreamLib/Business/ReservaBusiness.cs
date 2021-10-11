using HotelDreamLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Business
{
    public class ReservaBusiness
    {
        public double CalcularReserva(ReservaModel reserva)
        {
            int qtdDias = reserva.DtSaida.Subtract(reserva.DtEntrada).Days;
            return (reserva.Quarto.TipoQuarto.Valor * qtdDias) + (reserva.QtdAcompanhante * 70);
        }
    }
}
