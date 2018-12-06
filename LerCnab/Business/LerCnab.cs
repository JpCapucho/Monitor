using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoletoNet;
using LerCnab.Model;

namespace LerCnab.Business
{
    public class LerCnab
    {
        public ArquivoRetornoCNAB400 LerArquivoCnab400(Stream arquivo, Model.Banco bank)
        {
            BoletoNet.Banco banco = new BoletoNet.Banco(bank.Codigo);
            ArquivoRetornoCNAB400 arquivoRetorno = new ArquivoRetornoCNAB400();

            try
            {
                arquivoRetorno.LerArquivoRetorno(banco, arquivo);
                return arquivoRetorno;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
