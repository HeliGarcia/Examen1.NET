using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Juego
{
    internal class Dado
    {
        private int _ladoMin;
        private int _ladoMax;

        public Dado()
        {
            _ladoMin = 1;
            _ladoMax = 6;
        }

        public int LadoMin
        {
            get { return _ladoMin; }
            set { _ladoMin = value; }
        }

        public int LadoMax
        {
            get { return _ladoMax; }
            set { _ladoMax = value; }
        }
    }
}
