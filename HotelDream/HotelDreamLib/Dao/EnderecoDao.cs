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
    public class EnderecoDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public void SetEndereco(EnderecoModel endereco)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ENDERECO_SET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@ID", endereco.Id));
                cmd.Parameters.Add(new SqlParameter("@CEP", endereco.CEP));
                cmd.Parameters.Add(new SqlParameter("@ESTADO", endereco.Estado));
                cmd.Parameters.Add(new SqlParameter("@CIDADE", endereco.Cidade));
                cmd.Parameters.Add(new SqlParameter("@BAIRRO", endereco.Bairro));
                cmd.Parameters.Add(new SqlParameter("@RUA", endereco.Rua));
                cmd.Parameters.Add(new SqlParameter("@NUMERO", endereco.Numero));
                cmd.Parameters.Add(new SqlParameter("@COMPLEMENTO", endereco.Complemento));

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

        public EnderecoModel GetEndereco(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_ENDERECO WHERE ID=" + id)
                {
                    CommandType = CommandType.Text,
                    Connection = conn
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                EnderecoModel endereco = new EnderecoModel();

                foreach (DataRow linha in dt.Rows)
                {

                    endereco.Id = int.Parse(linha["ID"].ToString());
                    endereco.CEP = linha["CEP"].ToString();
                    endereco.Estado = linha["ESTADO"].ToString();
                    endereco.Cidade = linha["CIDADE"].ToString();
                    endereco.Bairro = linha["BAIRRO"].ToString();
                    endereco.Rua = linha["RUA"].ToString();
                    endereco.Numero = linha["NUMERO"].ToString();
                    endereco.Complemento = linha["COMPLEMENTO"].ToString();
                }
                return endereco;
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

