using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Dao
{
    class Config
    {
        public static string GetStringConn()
        {
            return "Data Source = DESKTOP-FBE2BPP\\SQLEXPRESS;Initial Catalog = DreamHotel; User id = sa; Password=010699;";
        }
    }
}
