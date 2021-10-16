using Correios;
using HotelDreamLib.Model;
using System;

namespace HotelDreamLib.Services
{
    public class Correios
    {
        public RetornoCepModel BuscarCep(string cep)
        {
            CorreiosApi correiosApi = new CorreiosApi();
            RetornoCepModel retornoCep = new RetornoCepModel();

            var retorno = correiosApi.consultaCEP(cep);

            retornoCep.Estado = retorno.uf;
            retornoCep.Cidade = retorno.cidade;
            retornoCep.Bairro = retorno.bairro;
            retornoCep.Rua = retorno.end;

            return retornoCep;

        }
    }
}
