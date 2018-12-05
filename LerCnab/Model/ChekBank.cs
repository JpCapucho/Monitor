using LerCnab.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerCnab.Model
{
    public class ChekBank
    {
        public int VerificarBanco(Banco banco, ICodigoBanco codigo)
        {
            int codigoBanco = codigo.Codigo(banco);
            return codigoBanco;
        }
    }
}
