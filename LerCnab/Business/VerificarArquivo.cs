using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerCnab.Business
{
    public class VerificarArquivo
    {
        /// <summary>
        /// Se retornar um codigo válido, grava o arquivo em uma pasta para ser lido
        /// </summary>
        public void GravarArquivo()
        {

        }

        /// <summary>
        /// Ler o arquivo e retorna o Codigo do Banco, se existir!
        /// </summary>
        /// <param name="stream"></param>
        /// <returns><see cref="int CodigoBanco"/></returns>
        public int CodigoBanco(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                try
                {
                    var file = reader.ReadLine();
                    var codigo = Convert.ToInt32(file.Substring(76, 3));
                    return codigo;
                }
                catch 
                {
                    throw new Exception("Erro ao ler o arquivo!");
                }

            }
        }
    }
}
