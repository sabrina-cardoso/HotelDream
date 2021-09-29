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
    public class QuartoDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public DataTable GetListQuartoReserva(DateTime dataEntrada, DateTime dataSaida)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_QUARTO_RESERVA_GET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@DATE_ENTRADA", dataEntrada));
                cmd.Parameters.Add(new SqlParameter("@DATE_SAIDA", dataSaida));
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

        public QuartoModel GetQuarto(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_QUARTO WHERE ID=" + id)
                {
                    CommandType = CommandType.Text,
                    Connection = conn
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                QuartoModel quarto = new QuartoModel();

                foreach (DataRow linha in dt.Rows)
                {
                    quarto.Id = Convert.ToInt32(linha["ID"]);
                    quarto.TipoQuarto = GetTipoQuarto(linha["TIPOQUARTO"].ToString());
                }
                return quarto;
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

        public QuartoTipoModel GetTipoQuarto(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_QUARTO_TIPO WHERE ID=" + id)
                {
                    CommandType = CommandType.Text,
                    Connection = conn
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                QuartoTipoModel tipoQuarto = new QuartoTipoModel();

                foreach (DataRow linha in dt.Rows)
                {

                    tipoQuarto.Id = Convert.ToInt32(linha["ID"]);
                    tipoQuarto.Nome = linha["NOME"].ToString();
                    tipoQuarto.QtdHospede = int.Parse(linha["QTDHOSPEDE"].ToString());
                    tipoQuarto.QtdCamaSolteiro = int.Parse(linha["QTDCAMASOLTEIRO"].ToString());
                    tipoQuarto.QtdCamaCasal = int.Parse(linha["QTDCAMACASAL"].ToString());
                    tipoQuarto.Foto = linha["FOTO"].ToString();
                    tipoQuarto.Descricao = linha["DESCRICAO"].ToString();
                    tipoQuarto.Valor = Convert.ToDouble(linha["VALOR"]);
                }
                return tipoQuarto;
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
