﻿using Planetario.Frontend.Crear.Planetario;
using Planetario.Frontend.Editrar.Planetario;
using Planetario.Frontend.Eliminar.Planetario;
using Planetario.Frontend.Mostrar.Planetario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario.Frontend.Principal.Planetario
{
    public class MenuPlaneta
    {
        public static void MostrarMenu()
        {
            int _opcionUsuario = 9;

            Console.Clear();

            while (_opcionUsuario != 0)
            {
                Console.WriteLine("\nMenu Planeta");
                Console.WriteLine("1. Crear planeta");
                Console.WriteLine("2. Visualizar planetas");
                Console.WriteLine("3. Editar planeta");
                Console.WriteLine("4. Eliminar planeta");
                Console.WriteLine("0. Salir del menu planeta");
                Console.WriteLine("Seleccione una opcion: ");

                _opcionUsuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (_opcionUsuario)
                {
                    case 1:
                        CrearPlaneta.Crear();
                        break;

                    case 2:
                        MostrarPlanetas.MostrarMenu();
                        break;

                    case 3:
                        EditarPlaneta.Editar();
                        break;

                    case 4:
                        EliminarPlaneta.Eliminar();
                        break;

                    case 0:
                        break;

                    default:
                        MostrarMenu();
                        break;
                }
            }
        }
    }
}
