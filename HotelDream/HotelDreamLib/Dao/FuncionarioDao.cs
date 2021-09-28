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
    public class FuncionarioDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public void SetFuncionario(FuncionarioModel funcionario)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_FUNCIONARIO_SET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@ID", funcionario.Id));
                cmd.Parameters.Add(new SqlParameter("@NOME", funcionario.Nome));
                cmd.Parameters.Add(new SqlParameter("@CPF", funcionario.CPF));
                cmd.Parameters.Add(new SqlParameter("@RG", funcionario.RG));
                cmd.Parameters.Add(new SqlParameter("@DATANASC", funcionario.DataNasc));
                cmd.Parameters.Add(new SqlParameter("@TELEFONE", funcionario.Telefone));
                cmd.Parameters.Add(new SqlParameter("@SETOR", funcionario.Setor));
                cmd.Parameters.Add(new SqlParameter("@SITUACAO", funcionario.Situacao));
                cmd.Parameters.Add(new SqlParameter("@DATAADM", funcionario.DataAdm));
                cmd.Parameters.Add(new SqlParameter("@DATADEM", null));
                cmd.Parameters.Add(new SqlParameter("@SALARIO", funcionario.Salario));

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

        public DataTable GetListFuncionario(string busca = "")
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_FUNCIONARIO_GET", conn)
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

        public FuncionarioModel GetFuncionario(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_FUNCIONARIO WHERE ID=" + id)
                {
                    CommandType = CommandType.Text,
                    Connection = conn
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                FuncionarioModel funcionario = new FuncionarioModel();

                foreach (DataRow linha in dt.Rows)
                {

                    funcionario.Id = int.Parse(linha["ID"].ToString());
                    funcionario.Nome = linha["NOME"].ToString();
                    funcionario.Nome = linha["NOME"].ToString();
                    funcionario.CPF = linha["CPF"].ToString();
                    funcionario.RG = linha["RG"].ToString();
                    funcionario.DataNasc = Convert.ToDateTime(linha["DATANASC"]);
                    funcionario.Telefone = linha["TELEFONE"].ToString();
                    funcionario.Setor = Convert.ToInt32(linha["SETOR"]);
                    funcionario.Situacao = Convert.ToInt32(linha["SITUACAO"]);
                    funcionario.DataAdm = Convert.ToDateTime(linha["DATAADM"]);
                    funcionario.DataDem = linha["DATADEM"] != DBNull.Value ? Convert.ToDateTime(linha["DATADEM"]) : Convert.ToDateTime("01/01/9998");
                    funcionario.Salario = Convert.ToDouble(linha["SALARIO"]);
                }
                return funcionario;
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

        public void DeleteFuncionario(string id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TB_FUNCIONARIO SET DEL_FLAG = 1 WHERE ID='" + id + "'", conn)
                {
                    CommandType = CommandType.Text
                };

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

        public DataTable GetSetor()
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_SETOR_TIPO")
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

        public DataTable GetSituacao()
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_SITUACAO")
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

    }
}
