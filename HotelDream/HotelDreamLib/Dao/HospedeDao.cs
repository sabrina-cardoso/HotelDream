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
    class HospedeDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public void SetHospede(HospedeModel hospede)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_CADASTRAR_HOSPEDE", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@ID", hospede.Id));
                cmd.Parameters.Add(new SqlParameter("@NOME", hospede.Nome));
                cmd.Parameters.Add(new SqlParameter("@CPF", hospede.CPF));
                cmd.Parameters.Add(new SqlParameter("@RG", hospede.RG));
                cmd.Parameters.Add(new SqlParameter("@DATANASC", hospede.DataNasc));
                cmd.Parameters.Add(new SqlParameter("@TELEFONE", hospede.Telefone));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", hospede.Email));

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

        public DataTable GetListHospede(string busca)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_LISTA_HOSPEDE", conn)
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

        public HospedeModel GetHospede(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_HOSPEDE WHERE ID=" + id)
                {
                    CommandType = CommandType.Text,
                    Connection = conn
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                HospedeModel hospedeModel = new HospedeModel();

                foreach (DataRow linha in dt.Rows)
                {

                    hospedeModel.Id = int.Parse(linha["ID"].ToString());
                    hospedeModel.Nome = linha["NOME"].ToString();
                    hospedeModel.Nome = linha["NOME"].ToString();
                    hospedeModel.CPF = linha["CPF"].ToString();
                    hospedeModel.RG = linha["RG"].ToString();
                    hospedeModel.DataNasc = linha["DATANASC"].ToString();
                    hospedeModel.Telefone = linha["TELEFONE"].ToString();
                    hospedeModel.Email = linha["EMAIL"].ToString();
                }
                return hospedeModel;
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

        public void UpdateHospede(HospedeModel hospede)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_ATUALIZAR_HOSPEDE", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@ID", hospede.Id));
                cmd.Parameters.Add(new SqlParameter("@NOME", hospede.Nome));
                cmd.Parameters.Add(new SqlParameter("@CPF", hospede.CPF));
                cmd.Parameters.Add(new SqlParameter("@RG", hospede.RG));
                cmd.Parameters.Add(new SqlParameter("@DATANASC", hospede.DataNasc));
                cmd.Parameters.Add(new SqlParameter("@TELEFONE", hospede.Telefone));
                cmd.Parameters.Add(new SqlParameter("@EMAIL", hospede.Email));

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

