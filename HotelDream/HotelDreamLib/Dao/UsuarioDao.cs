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
    public class UsuarioDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public void SetUsuario(UsuarioModel usuario)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("dbo.SP_USUARIO_SET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@ID", usuario.Id));
                cmd.Parameters.Add(new SqlParameter("@NIVEL", usuario.Nivel));
                cmd.Parameters.Add(new SqlParameter("@USUARIO", usuario.Usuario));
                cmd.Parameters.Add(new SqlParameter("@SENHA", usuario.Senha));
                cmd.Parameters.Add(new SqlParameter("@STATUS", usuario.Status));
                cmd.ExecuteNonQuery();

                conn.Close();
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

        public object GetStatus()
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("SELECT * FROM TB_STATUS_USUARIO")
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

        public string GetIdUsuario(string user)
        {
            try
            {
                conn.Open();
                string id = "";
                string sql = "SELECT ID FROM TB_USUARIO WHERE USUARIO = '" + user + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader["ID"].ToString();
                }
                conn.Close();
                return id;
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

        public DataTable GetListUsuario(string busca = "")
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_USUARIO_GET", conn)
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
