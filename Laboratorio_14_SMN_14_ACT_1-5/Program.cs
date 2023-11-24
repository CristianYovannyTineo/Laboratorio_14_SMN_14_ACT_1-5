using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_14_SMN_14_ACT_1_5
{
    
    
        class Program
        {
            static int[] edades = new int[1000];
            static bool[] vacunados = new bool[1000];
            static int totalEncuestas = 0;

            static void Main()
            {
                int opcion;
                do
                {
                    Console.Clear();
                    MostrarMenu();
                    opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            RealizarEncuestas();
                            break;
                        case 2:
                            MostrarDatosEncuesta();
                            break;
                        case 3:
                            MostrarResultados();
                            break;
                        case 4:
                            BuscarPorEdad();
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa.");
                            break;
                        default:
                            break;
                    }

                    Console.ReadKey();
                } while (opcion != 5);
            }

            static void MostrarMenu()
            {
            Console.WriteLine("===============================\n" +
            "Encuesta Covid-19\n" +
            "===============================\n" +
            "1: Realizar encuestas\n" +
            "2: Mostrar Datos de la encuesta\n" +
            "3: Mostrar Resultados\n" +
            "4: Buscar Personas por edad\n" +
            "5: Salir\n" +
            "===============================");
                Console.Write("Ingrese una opción: ");
            }

            static void RealizarEncuestas()
            {
                Console.Clear();
            Console.WriteLine("===============================\n" +
            "Encuesta de vacunación\n" +
            "===============================");

                do
                {
                    Console.Write("¿Qué edad tienes?: ");
                    int edad = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Te has vacunado\n"+
                    "1: Si\n"+
                    "2: No\n"+
                    "=================================");
                    Console.Write("Ingrese una opción: ");
                    bool vacunado = Console.ReadLine() == "1";

                    edades[totalEncuestas] = edad;
                    vacunados[totalEncuestas] = vacunado;

                    totalEncuestas++;

                    Console.Write("¿Deseas realizar otra encuesta? (Sí/No): ");
                } while (Console.ReadLine().ToLower() == "si");

                Console.WriteLine("¡Gracias por participar!");
            }

            static void MostrarDatosEncuesta()
            {
                Console.Clear();
            Console.WriteLine("===============================\n" +
            "Datos de la encuesta\n" +
            "===============================\n" +
            "ID\t\t|     EDAD\t     |    Vacunado\n" +
            "===============================");

                for (int i = 0; i < totalEncuestas; i++)
                {
                    Console.WriteLine($"{i:D4}\t\t|     {edades[i]:D2}\t\t     |    {(vacunados[i] ? "Si" : "No")}");
                }

                Console.WriteLine("===============================");
                Console.WriteLine("Presione una tecla para regresar...");
            }

            static void MostrarResultados()
            {
                Console.Clear();
            Console.WriteLine("===============================\n" +
            "Resultados de la encuesta\n" +
            "===============================");

                int vacunadosCount = 0;
                int noVacunadosCount = 0;

                int[] edadCount = new int[6];

                for (int i = 0; i < totalEncuestas; i++)
                {
                    if (vacunados[i])
                    {
                        vacunadosCount++;
                    }
                    else
                    {
                        noVacunadosCount++;
                    }

                    if (edades[i] >= 1 && edades[i] <= 20)
                    {
                        edadCount[0]++;
                    }
                    else if (edades[i] >= 21 && edades[i] <= 30)
                    {
                        edadCount[1]++;
                    }
                    else if (edades[i] >= 31 && edades[i] <= 40)
                    {
                        edadCount[2]++;
                    }
                    else if (edades[i] >= 41 && edades[i] <= 50)
                    {
                        edadCount[3]++;
                    }
                    else if (edades[i] >= 51 && edades[i] <= 60)
                    {
                        edadCount[4]++;
                    }
                    else
                    {
                        edadCount[5]++;
                    }
                }

                Console.WriteLine($"{vacunadosCount} personas se han vacunado");
                Console.WriteLine($"{noVacunadosCount} personas no se han vacunado");
                Console.WriteLine();
                Console.WriteLine("Existen:\n"+
                $"{edadCount[0]} Personas entre 01 y 20 años\n"+
                $"{edadCount[1]} Personas entre 21 y 30 años\n"+
                $"{edadCount[2]} Personas entre 31 y 40 años\n"+
                $"{edadCount[3]} Personas entre 41 y 50 años\n"+
                $"{edadCount[4]} Personas entre 51 y 60 años\n"+
                $"{edadCount[5]} personas de más de 61 años");

                Console.WriteLine("===============================");
                Console.WriteLine("Presione una tecla para regresar...");
            }

            static void BuscarPorEdad()
            {
                Console.Clear();
                Console.WriteLine("===============================\n" +
                "Buscar personas por edad\n"+
                "===============================");

                Console.Write("¿Qué edad quieres buscar?: ");
                int edadBuscada = Convert.ToInt32(Console.ReadLine());

                int vacunadosCount = 0;
                int noVacunadosCount = 0;

                for (int i = 0; i < totalEncuestas; i++)
                {
                    if (edades[i] == edadBuscada)
                    {
                        if (vacunados[i])
                        {
                            vacunadosCount++;
                        }
                        else
                        {
                            noVacunadosCount++;
                        }
                    }
                }

                Console.WriteLine($"{vacunadosCount} se vacunaron");
                Console.WriteLine($"{noVacunadosCount} no se vacunaron");

                Console.WriteLine("===============================");
                Console.WriteLine("Presione una tecla para regresar...");
            }




        }
    
}
