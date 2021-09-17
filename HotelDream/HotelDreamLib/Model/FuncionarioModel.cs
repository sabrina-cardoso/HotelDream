using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNasc { get; set; }
        public string Telefone { get; set; }
        public int Setor { get; set; }
        public int Situacao { get; set; }
        public DateTime DataAdm { get; set; }
        public DateTime DataDem { get; set; }
        public double Salario { get; set; }
    }
}
