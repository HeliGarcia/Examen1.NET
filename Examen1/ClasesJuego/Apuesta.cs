using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Juego
{
    internal class Apuesta
    {
        protected string _tipoApuesta;
        protected double _dineroApostado;

        public Apuesta(string tipoApuesta, double dinero)
        {
            _tipoApuesta = tipoApuesta;
            _dineroApostado = dinero;
        }
        

        public string TipoApuesta
        {
            get { return _tipoApuesta;}
            set { _tipoApuesta = value;}
        }

        public double DineroApostado
        {
            get { return _dineroApostado;}
            set { _dineroApostado = value;}
        }
    }
}
