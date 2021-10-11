using HotelDreamLib.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDreamLib.Dao
{
    public class AcompanhanteDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());
        public void SetAcompanhante(AcompanhanteModel acompanhante )
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_ACOMPANHANTE_SET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@NOME", acompanhante.Nome));
                cmd.Parameters.Add(new SqlParameter("@CPF", acompanhante.CPF));
                cmd.Parameters.Add(new SqlParameter("@RESERVA", acompanhante.Reserva.Id));

                cmd.ExecuteNonQuery();
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

        public DataTable GetListAcompanhante(ReservaModel reserva)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_ACOMPANHANTE_GET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@RESERVA", reserva.Id));
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
