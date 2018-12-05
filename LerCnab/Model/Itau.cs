using LerCnab.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerCnab.Model
{
    public class Itau : ICodigoBanco
    {
        public int Codigo(Banco banco)
        {
            return banco.Codigo = 341;
        }
    }
}
