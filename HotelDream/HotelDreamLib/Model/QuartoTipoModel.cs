using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class QuartoTipoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdHospede { get; set; }
        public int QtdCamaSolteiro { get; set; }
        public int QtdCamaCasal { get; set; }
        public string Foto { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
