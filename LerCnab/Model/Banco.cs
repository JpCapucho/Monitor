using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerCnab.Model
{
    public class Banco
    {
        public int Codigo { get; set; }

        public Banco(int codigo)
        {
            Codigo = codigo;
        }
    }
}
