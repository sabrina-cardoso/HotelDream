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
    public class ReservaDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public void SetReserva(ReservaModel reserva)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_RESERVA_SET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@HOSPEDE", reserva.Hospede.Id));
                cmd.Parameters.Add(new SqlParameter("@QUARTO", reserva.Quarto.Id));
                cmd.Parameters.Add(new SqlParameter("@DTENTRADA", reserva.DtEntrada));
                cmd.Parameters.Add(new SqlParameter("@DTSAIDA", reserva.DtSaida));
                cmd.Parameters.Add(new SqlParameter("@TIPOPAGAMENTO", reserva.TipoPagamento));
                cmd.Parameters.Add(new SqlParameter("@TOTAL", reserva.Total));
                cmd.Parameters.Add(new SqlParameter("@QTDACOMP", reserva.QtdAcompanhante));

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    reserva.Id = Convert.ToInt32(reader["Id"]);
                }

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

        public DataTable GetListReserva(string busca)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_RESERVA_GET", conn)
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

        public DataTable GetTipoPagamento()
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_PAGAMENTO_TIPO")
                {
                    CommandType = CommandType.Text,
                    Connection = conn
                };
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

        public void CheckIn(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_RESERVA_CHECKIN", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@ID", id));
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

        public void CheckOut(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_RESERVA_CHECKOUT", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@ID", id));
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

    }
}
