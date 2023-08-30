using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaException.Entidades.Exception
{
    internal class ExcecaoDominio:ApplicationException
    {
        public ExcecaoDominio(string mensagem) : base(mensagem)
        {

        }
    }
}
