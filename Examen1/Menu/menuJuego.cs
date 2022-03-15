using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen1.Juego;

namespace Examen1.Menu
{
    internal class menuJuego
    {
        string opcion;
        string opcion2="0";
        int numaApostar = 0;
        double dineroApostado;
        double ganancia;
        double ganadoperdido = 0;
        Boolean confirmacion;
        Jugador jugador;
        Dado dado;
        Apuesta apuesta;
        Tirada tirada;
        Jugar jugar;
        Instrucciones instrucciones = new Instrucciones();
        List<int> historial = new List<int>();

        public void menu()
        {
            Console.WriteLine("Bienvenido al juego de dados.\n");
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa tu nombre: \n");
            jugador = new Jugador(Console.ReadLine());
            dado = new Dado();
            do
            {
                Console.WriteLine("\nIngresa una de las siguientes opciones: \n");
                Console.WriteLine("[1] Apostar a un número específico (ganancia x10).\n" +
                    "[2] Apostar a un número en un extremo (ganancia x8).\n" +
                    "[3] Apostar a un número medio (ganancia x4).\n" +
                    "[4] Apostar a un número par (ganancia x2).\n" +
                    "[5] Apostar a un número impar (ganancia x2).\n" +
                    "[6] Estadísticas.\n" +
                    "[7] Instrucciones.\n" +
                    "[9] Retirarse del juego.\n");

                opcion = Console.ReadLine();
                confirmacion = false;

                if (opcion.Equals("1"))
                {
                    while (confirmacion == false)
                    {
                        Console.WriteLine("\nIngresa el número al que quieres apostar: \n");
                        numaApostar = Console.Read();
                        if (numaApostar >= 2 && numaApostar <= 12)//se valida si el número pertenece al rango.
                        {
                            Console.WriteLine("\nIngresa la cantidad de dinero a apostar: \n");
                            dineroApostado = Console.Read();
                            if (dineroApostado <= jugador.Dinero)//Se valida si el jugador tiene dinero suficiente para realizar la apuesta.
                            {
                                confirmacion = true;
                            }
                            else
                            {
                                Console.WriteLine("No tienes dinero suficiente para realizar la apuesta.\n");
                                Console.WriteLine("Te queda $" + jugador.Dinero + "\n");
                                confirmacion = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ingresa un número válido al cual apostar.\n");
                            confirmacion = false;
                        }
                    }

                    apuesta = new Apuesta("Número específico", dineroApostado);
                    tirada = new Tirada(jugador, dado);
                    jugar = new Jugar(jugador, dado, apuesta);

                    historial.Add(tirada.ValorTirada);
                    jugador.Dinero = jugador.Dinero - apuesta.DineroApostado;
                    if (jugar.Gana(apuesta, tirada, numaApostar))
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n¡Ganaste!\n");
                        ganancia = apuesta.DineroApostado * 10;
                        jugador.Dinero = jugador.Dinero + ganancia;
                    }
                    else
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n¡Que lástima!\n");
                        Console.WriteLine("Te queda " + jugador.Dinero + " \n");
                    }
                }

                else if (opcion.Equals("2"))
                {
                    while (confirmacion == false)
                    {
                        Console.WriteLine("\nIngresa la cantidad de dinero a apostar: \n");
                        dineroApostado = Console.Read();
                        if (dineroApostado <= jugador.Dinero)
                        {
                            confirmacion = true;
                        }
                        else
                        {
                            Console.WriteLine("No tienes dinero suficiente para realizar la apuesta.\n");
                            Console.WriteLine("Te queda $" + jugador.Dinero + "\n");
                            confirmacion = false;
                        }
                    }

                    apuesta = new Apuesta("Extremos", dineroApostado);
                    tirada = new Tirada(jugador, dado);
                    jugar = new Jugar(jugador, dado, apuesta);

                    historial.Add(tirada.ValorTirada);
                    jugador.Dinero = jugador.Dinero - apuesta.DineroApostado;
                    if (jugar.Gana(apuesta, tirada, numaApostar))
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n¡Ganaste!\n");
                        ganancia = apuesta.DineroApostado * 8;
                        jugador.Dinero = jugador.Dinero + ganancia;
                    }
                    else
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n ¡Que lástima!\n");
                        Console.WriteLine("Te queda $" + jugador.Dinero + " \n");
                    }
                }

                else if (opcion.Equals("3"))
                {
                    while (confirmacion == false)
                    {
                        Console.WriteLine("\nIngresa la cantidad de dinero a apostar: \n");
                        dineroApostado = Console.Read();
                        if (dineroApostado <= jugador.Dinero)
                        {
                            confirmacion = true;
                        }
                        else
                        {
                            Console.WriteLine("No tienes dinero suficiente para realizar la apuesta.\n");
                            Console.WriteLine("Te queda $" + jugador.Dinero + "\n");
                            confirmacion = false;
                        }
                    }

                    apuesta = new Apuesta("Medios", dineroApostado);
                    tirada = new Tirada(jugador, dado);
                    jugar = new Jugar(jugador, dado, apuesta);

                    historial.Add(tirada.ValorTirada);
                    jugador.Dinero = jugador.Dinero - apuesta.DineroApostado;

                    if (jugar.Gana(apuesta, tirada, numaApostar))
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n¡Ganaste!\n");
                        ganancia = apuesta.DineroApostado * 4;
                        jugador.Dinero = jugador.Dinero + ganancia;
                    }
                    else
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n ¡Que lástima!\n");
                        Console.WriteLine("Te queda $" + jugador.Dinero + " \n");
                    }
                }

                else if (opcion.Equals("4"))
                {
                    while (confirmacion == false)
                    {
                        Console.WriteLine("\nIngresa la cantidad de dinero a apostar: \n");
                        dineroApostado = Console.Read();
                        if (dineroApostado <= jugador.Dinero)
                        {
                            confirmacion = true;
                        }
                        else
                        {
                            Console.WriteLine("No tienes dinero suficiente para realizar la apuesta.\n");
                            Console.WriteLine("Te queda $" + jugador.Dinero + "\n");
                            confirmacion = false;
                        }
                    }

                    apuesta = new Apuesta("Par", dineroApostado);
                    tirada = new Tirada(jugador, dado);
                    jugar = new Jugar(jugador, dado, apuesta);

                    historial.Add(tirada.ValorTirada);
                    jugador.Dinero = jugador.Dinero - apuesta.DineroApostado;

                    if (jugar.Gana(apuesta, tirada, numaApostar))
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n¡Ganaste!\n");
                        ganancia = apuesta.DineroApostado * 2;
                        jugador.Dinero = jugador.Dinero + ganancia;
                    }
                    else
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n ¡Que lástima!\n");
                        Console.WriteLine("Te queda $" + jugador.Dinero + " \n");
                    }
                }

                else if (opcion.Equals("5"))
                {
                    while (confirmacion == false)
                    {
                        Console.WriteLine("\nIngresa la cantidad de dinero a apostar: \n");
                        dineroApostado = Console.Read();
                        if (dineroApostado <= jugador.Dinero)
                        {
                            confirmacion = true;
                        }
                        else
                        {
                            Console.WriteLine("No tienes dinero suficiente para realizar la apuesta.\n");
                            Console.WriteLine("Te queda $" + jugador.Dinero + "\n");
                            confirmacion = false;
                        }
                    }

                    apuesta = new Apuesta("Impar", dineroApostado);
                    tirada = new Tirada(jugador, dado);
                    jugar = new Jugar(jugador, dado, apuesta);

                    historial.Add(tirada.ValorTirada);
                    jugador.Dinero = jugador.Dinero - apuesta.DineroApostado;

                    if (jugar.Gana(apuesta, tirada, numaApostar))
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n¡Ganaste!\n");
                        ganancia = apuesta.DineroApostado * 2;
                        jugador.Dinero = jugador.Dinero + ganancia;
                    }
                    else
                    {
                        Console.WriteLine("\nCayó " + tirada.ValorTirada);
                        Console.WriteLine("\n ¡Que lástima!\n");
                        Console.WriteLine("Te queda $" + jugador.Dinero + " \n");
                    }
                }
                else if (opcion.Equals("6"))
                {
                    while (!opcion2.Equals("9"))//Se muestra un menú con las estadísticas disponibles a mostrar.
                    {
                        Console.WriteLine("[1] Mostrar dinero actual.\n" +
                        "[2] Mostrar cantidad de tiradas realizadas.\n" +
                        "[3] Mostrar el número que más veces se ha tirado.\n" +
                        "[4] Mostrar el número que menos veces se ha tirado.\n" +
                        "[5] Mostrar la cantidad de resultados que han sido extremos.\n" +
                        "[6] Mostrar la cantidad de resultados que han sido medios.\n" +
                        "[7] Mostrar la cantidad de resultados que han sido par.\n" +
                        "[8] Mostrar la cantidad de resultados que han sido impar.\n" +
                        "[9] Regresar.\n");

                        opcion2 = Console.ReadLine();

                        if (opcion2.Equals("1"))
                        {
                            Console.WriteLine("Tu dinero actual es $" + jugador.Dinero + "\n");
                        }

                        else if (opcion2.Equals("2"))
                        {
                            Console.WriteLine("Ha tirado " + historial.Count + "\n");
                        }

                        else if (opcion2.Equals("3"))
                        {
                            int numeromas = 0;
                            int veces2 = 0;
                            int veces3 = 0;
                            int veces4 = 0;
                            int veces5 = 0;
                            int veces6 = 0;
                            int veces7 = 0;
                            int veces8 = 0;
                            int veces9 = 0;
                            int veces10 = 0;
                            int veces11 = 0;
                            int veces12 = 0;

                            for (int i = 0; i < historial.Count; i++)
                            {
                                if (historial[i] == 2)
                                {
                                    veces2++;
                                }
                                else if (historial[i] == 3)
                                {
                                    veces3++;
                                }
                                else if (historial[i] == 4)
                                {
                                    veces4++;
                                }
                                else if (historial[i] == 5)
                                {
                                    veces5++;
                                }
                                else if (historial[i] == 6)
                                {
                                    veces6++;
                                }
                                else if (historial[i] == 7)
                                {
                                    veces7++;
                                }
                                else if (historial[i] == 8)
                                {
                                    veces8++;
                                }
                                else if (historial[i] == 9)
                                {
                                    veces9++;
                                }
                                else if (historial[i] == 10)
                                {
                                    veces10++;
                                }
                                else if (historial[i] == 11)
                                {
                                    veces11++;
                                }
                                else if (historial[i] == 12)
                                {
                                    veces12++;
                                }
                            }

                            if (veces2 > veces3 && veces2 > veces4 && veces2 > veces5 && veces2 > veces6 && veces2 > veces7 && veces2 > veces8 && veces2 > veces9 && veces2 > veces10 && veces2 > veces11 && veces2 > veces12)
                            {
                                numeromas = 2;
                            }
                            else if (veces3 > veces2 && veces3 > veces4 && veces3 > veces5 && veces3 > veces6 && veces3 > veces7 && veces3 > veces8 && veces3 > veces9 && veces3 > veces10 && veces3 > veces11 && veces3 > veces12)
                            {
                                numeromas = 3;
                            }
                            else if (veces4 > veces2 && veces4 > veces3 && veces4 > veces5 && veces4 > veces6 && veces4 > veces7 && veces4 > veces8 && veces4 > veces9 && veces4 > veces10 && veces4 > veces11 && veces4 > veces12)
                            {
                                numeromas = 4;
                            }
                            else if (veces5 > veces2 && veces5 > veces4 && veces5 > veces3 && veces5 > veces6 && veces5 > veces7 && veces5 > veces8 && veces5 > veces9 && veces5 > veces10 && veces5 > veces11 && veces5 > veces12)
                            {
                                numeromas = 5;
                            }
                            else if (veces6 > veces2 && veces6 > veces4 && veces6 > veces5 && veces6 > veces3 && veces6 > veces7 && veces6 > veces8 && veces6 > veces9 && veces6 > veces10 && veces6 > veces11 && veces6 > veces12)
                            {
                                numeromas = 6;
                            }
                            else if (veces7 > veces2 && veces7 > veces4 && veces7 > veces5 && veces7 > veces6 && veces7 > veces3 && veces7 > veces8 && veces7 > veces9 && veces7 > veces10 && veces7 > veces11 && veces7 > veces12)
                            {
                                numeromas = 7;
                            }
                            else if (veces8 > veces2 && veces8 > veces4 && veces8 > veces5 && veces8 > veces6 && veces8 > veces7 && veces8 > veces3 && veces8 > veces9 && veces8 > veces10 && veces8 > veces11 && veces8 > veces12)
                            {
                                numeromas = 8;
                            }
                            else if (veces9 > veces2 && veces9 > veces4 && veces9 > veces5 && veces9 > veces6 && veces9 > veces7 && veces9 > veces8 && veces9 > veces3 && veces9 > veces10 && veces9 > veces11 && veces9 > veces12)
                            {
                                numeromas = 9;
                            }
                            else if (veces10 > veces2 && veces10 > veces4 && veces10 > veces5 && veces10 > veces6 && veces10 > veces7 && veces10 > veces8 && veces10 > veces9 && veces10 > veces3 && veces10 > veces11 && veces10 > veces12)
                            {
                                numeromas = 10;
                            }
                            else if (veces11 > veces2 && veces11 > veces4 && veces11 > veces5 && veces11 > veces6 && veces11 > veces7 && veces11 > veces8 && veces11 > veces9 && veces11 > veces10 && veces11 > veces3 && veces11 > veces12)
                            {
                                numeromas = 11;
                            }
                            else if (veces12 > veces2 && veces12 > veces4 && veces12 > veces5 && veces12 > veces6 && veces12 > veces7 && veces12 > veces8 && veces12 > veces9 && veces12 > veces10 && veces12 > veces11 && veces12 > veces3)
                            {
                                numeromas = 12;
                            }
                            Console.WriteLine("El número que más veces se ha tirado es: " + numeromas + "\n");

                        }

                        else if (opcion2.Equals("4"))
                        {
                            int numeromenos = 0;
                            int veces2 = 0;
                            int veces3 = 0;
                            int veces4 = 0;
                            int veces5 = 0;
                            int veces6 = 0;
                            int veces7 = 0;
                            int veces8 = 0;
                            int veces9 = 0;
                            int veces10 = 0;
                            int veces11 = 0;
                            int veces12 = 0;

                            for (int i = 0; i < historial.Count; i++)
                            {
                                if (historial[i] == 2)
                                {
                                    veces2++;
                                }
                                else if (historial[i] == 3)
                                {
                                    veces3++;
                                }
                                else if (historial[i] == 4)
                                {
                                    veces4++;
                                }
                                else if (historial[i] == 5)
                                {
                                    veces5++;
                                }
                                else if (historial[i] == 6)
                                {
                                    veces6++;
                                }
                                else if (historial[i] == 7)
                                {
                                    veces7++;
                                }
                                else if (historial[i] == 8)
                                {
                                    veces8++;
                                }
                                else if (historial[i] == 9)
                                {
                                    veces9++;
                                }
                                else if (historial[i] == 10)
                                {
                                    veces10++;
                                }
                                else if (historial[i] == 11)
                                {
                                    veces11++;
                                }
                                else if (historial[i] == 12)
                                {
                                    veces12++;
                                }
                            }

                            if (veces2 > veces3 && veces2 > veces4 && veces2 > veces5 && veces2 > veces6 && veces2 > veces7 && veces2 > veces8 && veces2 > veces9 && veces2 > veces10 && veces2 > veces11 && veces2 > veces12)
                            {
                                numeromenos = 2;
                            }
                            else if (veces3 < veces2 && veces3 < veces4 && veces3 < veces5 && veces3 < veces6 && veces3 < veces7 && veces3 < veces8 && veces3 < veces9 && veces3 < veces10 && veces3 < veces11 && veces3 < veces12)
                            {
                                numeromenos = 3;
                            }
                            else if (veces4 < veces2 && veces4 < veces3 && veces4 < veces5 && veces4 < veces6 && veces4 < veces7 && veces4 < veces8 && veces4 < veces9 && veces4 < veces10 && veces4 < veces11 && veces4 < veces12)
                            {
                                numeromenos = 4;
                            }
                            else if (veces5 < veces2 && veces5 < veces4 && veces5 < veces3 && veces5 < veces6 && veces5 < veces7 && veces5 < veces8 && veces5 < veces9 && veces5 < veces10 && veces5 < veces11 && veces5 < veces12)
                            {
                                numeromenos = 5;
                            }
                            else if (veces6 < veces2 && veces6 < veces4 && veces6 < veces5 && veces6 < veces3 && veces6 < veces7 && veces6 < veces8 && veces6 < veces9 && veces6 < veces10 && veces6 < veces11 && veces6 < veces12)
                            {
                                numeromenos = 6;
                            }
                            else if (veces7 < veces2 && veces7 < veces4 && veces7 < veces5 && veces7 < veces6 && veces7 < veces3 && veces7 < veces8 && veces7 < veces9 && veces7 < veces10 && veces7 < veces11 && veces7 < veces12)
                            {
                                numeromenos = 7;
                            }
                            else if (veces8 < veces2 && veces8 < veces4 && veces8 < veces5 && veces8 < veces6 && veces8 < veces7 && veces8 < veces3 && veces8 < veces9 && veces8 < veces10 && veces8 < veces11 && veces8 < veces12)
                            {
                                numeromenos = 8;
                            }
                            else if (veces9 < veces2 && veces9 < veces4 && veces9 < veces5 && veces9 < veces6 && veces9 < veces7 && veces9 < veces8 && veces9 < veces3 && veces9 < veces10 && veces9 < veces11 && veces9 < veces12)
                            {
                                numeromenos = 9;
                            }
                            else if (veces10 < veces2 && veces10 < veces4 && veces10 < veces5 && veces10 < veces6 && veces10 < veces7 && veces10 < veces8 && veces10 < veces9 && veces10 < veces3 && veces10 < veces11 && veces10 < veces12)
                            {
                                numeromenos = 10;
                            }
                            else if (veces11 < veces2 && veces11 < veces4 && veces11 < veces5 && veces11 < veces6 && veces11 < veces7 && veces11 < veces8 && veces11 < veces9 && veces11 < veces10 && veces11 < veces3 && veces11 < veces12)
                            {
                                numeromenos = 11;
                            }
                            else if (veces12 < veces2 && veces12 < veces4 && veces12 < veces5 && veces12 < veces6 && veces12 < veces7 && veces12 < veces8 && veces12 < veces9 && veces12 < veces10 && veces12 < veces11 && veces12 < veces3)
                            {
                                numeromenos = 12;
                            }
                            Console.WriteLine("El número que más veces se ha tirado es: " + numeromenos + "\n");

                        }

                        else if (opcion2.Equals("5"))
                        {
                            int vecesEx = 0;
                            for (int i = 0; i < historial.Count; i++)
                            {
                                if (historial[i] == 2 || historial[i] == 3 || historial[i] == 4 || historial[i] == 10 || historial[i] == 11 || historial[i] == 12)
                                {
                                    vecesEx++;
                                }
                            }
                            Console.WriteLine("Resultados que han sido extremos: " + vecesEx + "\n");
                        }

                        else if (opcion2.Equals("6"))
                        {
                            int vecesMed = 0;
                            for (int i = 0; i < historial.Count; i++)
                            {
                                if (historial[i] == 5 || historial[i] == 6 || historial[i] == 7 || historial[i] == 8 || historial[i] == 9)
                                {
                                    vecesMed++;
                                }
                            }
                            Console.WriteLine("Resultados que han sido medios: " + vecesMed + "\n");
                        }

                        else if (opcion2.Equals("7"))
                        {
                            int vecesPar = 0;
                            for (int i = 0; i < historial.Count; i++)
                            {
                                if (historial[i] % 2 == 0)
                                {
                                    vecesPar++;
                                }
                            }
                            Console.WriteLine("Resultados que han sido Par: " + vecesPar + "\n");
                        }

                        else if (opcion2.Equals("8"))
                        {
                            int vecesImpar = 0;
                            for (int i = 0; i < historial.Count; i++)
                            {
                                if (historial[i] % 2 != 0)
                                {
                                    vecesImpar++;
                                }
                            }
                            Console.WriteLine("Resultados que han sido Par: " + vecesImpar + "\n");
                        }

                        else if (opcion2.Equals("9"))
                        {
                            opcion2 = "9";
                        }

                        else
                        {
                            Console.WriteLine("Ingresa una opción válida.\n");
                        }
                    }


                }
                else if (opcion.Equals("7"))
                {
                    instrucciones.mostrarInstrucciones();
                }

                else if (opcion.Equals("9"))
                {
                    ganadoperdido = jugador.Dinero - 300;
                    if (ganadoperdido >= 0)
                    {
                        Console.WriteLine("Usted ha ganado $" + ganadoperdido + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Usted ha perdido $" + ganadoperdido + "\n");
                    }
                    Console.WriteLine("\nGracias por jugar.\n");
                    opcion = "9";
                }
                else
                {
                    Console.WriteLine("\nIngresa una opción válida.\n");
                }
            } while (!opcion.Equals("9"));
        }
    }
}
