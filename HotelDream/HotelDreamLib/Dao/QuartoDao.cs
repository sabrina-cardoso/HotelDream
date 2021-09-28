using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Dao
{
    public class QuartoDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public DataTable GetListQuarto(string busca = "")
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_QUARTO_RESERVA_GET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@BUSCA", busca));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
