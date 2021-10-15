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
    public class AvaliacaoDao
    {
        readonly SqlConnection conn = new SqlConnection(Config.GetStringConn());

        public DataTable GetListAvaliacao(string busca = "")
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_AVALIACAO_GET", conn)
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

        public NotaModel GetNotaEstatistica()
        {
            try
            {
                conn.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("dbo.SP_ESTATISTICA_NOTAS_GET", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                NotaModel nota = new NotaModel();

                foreach (DataRow linha in dt.Rows)
                {

                    nota.NotaAtendimentoRuim = Convert.ToInt32(linha["NOTA_ATENDIMENTO_RUIM"]);                 
                    nota.NotaAtendimentoRegular = Convert.ToInt32(linha["NOTA_ATENDIMENTO_REGULAR"]);
                    nota.NotaAtendimentoBom = Convert.ToInt32(linha["NOTA_ATENDIMENTO_BOM"]);
                    nota.NotaAtendimentoOtimo = Convert.ToInt32(linha["NOTA_ATENDIMENTO_OTIMO"]);
                    nota.NotaAtendimentoMedia = Convert.ToInt32(linha["NOTA_ATENDIMENTO_MEDIA"]);

                    nota.NotaAcomodacaoRuim = Convert.ToInt32(linha["NOTA_ACOMODACAO_RUIM"]);
                    nota.NotaAcomodacaoRegular = Convert.ToInt32(linha["NOTA_ACOMODACAO_REGULAR"]);
                    nota.NotaAcomodacaoBom = Convert.ToInt32(linha["NOTA_ACOMODACAO_BOM"]);
                    nota.NotaAcomodacaoOtimo = Convert.ToInt32(linha["NOTA_ACOMODACAO_OTIMO"]);
                    nota.NotaAcomodacaoMedia = Convert.ToInt32(linha["NOTA_ACOMODACAO_MEDIA"]);

                    nota.NotaRecomendacaoRuim = Convert.ToInt32(linha["NOTA_RECOMENDACAO_RUIM"]);
                    nota.NotaRecomendacaoRegular = Convert.ToInt32(linha["NOTA_RECOMENDACAO_REGULAR"]);
                    nota.NotaRecomendacaoBom = Convert.ToInt32(linha["NOTA_RECOMENDACAO_BOM"]);
                    nota.NotaRecomendacaoOtimo = Convert.ToInt32(linha["NOTA_RECOMENDACAO_OTIMO"]);
                    nota.NotaRecomendacaoMedia = Convert.ToInt32(linha["NOTA_RECOMENDACAO_MEDIA"]);
                }
                return nota;


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
