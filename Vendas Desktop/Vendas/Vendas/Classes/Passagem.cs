using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Vendas
{
    class Passagem
    {
         private int _os;
//        public int os;

        public Passagem(int os)
        {
            _os = os;
        }

        public Passagem()
        {

        }

        public int GetOs
        {
            get
            {
                return _os;

            }
        }

        public int SetOs
        {
            set
            {
                _os = value;
            }
        }
    }
}
