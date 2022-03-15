using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1.Juego
{
    internal class Jugar
    {
        private Jugador _jugador;
        private Dado _dado;
        private Apuesta _apuesta;
        private Tirada tirada;

        public Jugar(Jugador jugador, Dado dado, Apuesta apuesta)
        {
            _jugador = jugador;
            _dado = dado;
            _apuesta = apuesta;
            tirada = new Tirada(jugador, dado);
        }

        public Boolean Gana(Apuesta apuesta, Tirada tirada, int numaApostar)
        {
            if (apuesta.TipoApuesta.Equals("Número específico"))
            {
                if (tirada.ValorTirada == numaApostar)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (apuesta.TipoApuesta.Equals("Extremos"))
            {
                if (tirada.ValorTirada == 2 || tirada.ValorTirada == 3 || tirada.ValorTirada == 4 || tirada.ValorTirada == 10 || tirada.ValorTirada == 11 || tirada.ValorTirada == 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (apuesta.TipoApuesta.Equals("Medios"))
            {
                if (tirada.ValorTirada == 5 || tirada.ValorTirada == 6 || tirada.ValorTirada == 7 || tirada.ValorTirada == 8 || tirada.ValorTirada == 9)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (apuesta.TipoApuesta.Equals("Par"))
            {
                if (tirada.ValorTirada % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (apuesta.TipoApuesta.Equals("Impar"))
            {
                if (tirada.ValorTirada % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
