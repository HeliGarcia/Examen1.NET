using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Juego
{
    internal class Tirada
    {
        protected Jugador _jugador;
        protected Dado _dado;
        protected int _dado1;
        protected int _dado2;
        protected int _valorTirada;
        private Random random = new Random();

        public Tirada (Jugador jugador, Dado dado)
        {
            _jugador = jugador;
            _dado = dado;
            _dado1 = random.Next(dado.LadoMin, dado.LadoMax+1);
            _dado1 = random.Next(dado.LadoMin, dado.LadoMax+1);
            _valorTirada = _dado1 + _dado2;
        }

        public int ValorTirada
        {
            get { return _valorTirada; }
            set { _valorTirada = value; }
        }

        public int ValorDado1
        {
            get { return _dado1; }
            set { _dado1 = value; }
        }

        public int ValorDado2
        {
            get { return _dado2; }
            set { _dado2 = value; }
        }
    }
}
