using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Model
{
    public class QuartoModel
    {
        public int Id { get; set; }
        public QuartoTipoModel TipoQuarto { get; set; }
    }
}
