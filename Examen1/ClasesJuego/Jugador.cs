using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Juego
{
    internal class Jugador
    {
        private string _nombre;
        private double _dinero;


        public Jugador(string nombre)
        {
            _nombre = nombre;
            _dinero = 300;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public double Dinero
        {
            get { return _dinero; }
            set { _dinero = value; }
        }

    }
    
}
