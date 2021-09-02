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
    class LoginDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public int GetLogin(LoginModel loginModel)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("dbo.SP_LOGIN", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@USUARIO", loginModel.Usuario));
                cmd.Parameters.Add(new SqlParameter("@SENHA", loginModel.Senha));
                var dr = cmd.ExecuteReader();

                int cont = 0;
                while (dr.Read())
                {
                    cont += 1;
                }
                return cont;
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
