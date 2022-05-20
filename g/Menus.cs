using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g
{
    internal class Menus
    {

        public static void menus()
        {
            int operadores;
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("Elija 1. si desea hacer operaciones");
            Console.WriteLine("Elija 2. si desea ver los condicionales");
            Console.WriteLine("Elija 3. si desea ver los arreglos");
            Console.WriteLine("Elija 4. si desea ver los bucles");
            Console.WriteLine("Elija 0. si dese salir del programa");
            operadores = char.Parse(Console.ReadLine());
            switch (operadores)
            {
                case '1': operaciones(); break;
                case '2': Condicionales(); break;
                case '3': Arreglos(); break;
                case '4': Bucles(); break;
                case '0': Environment.Exit(1); ; break;
                default: Console.WriteLine("no especifico ninguna opcion"); break;
            }

        }
        public static void operaciones()
        {

        }


        public static void Condicionales()
        { }

            
    
        public static void Arreglos()
        {

        }
        public static void Bucles()
        {

        }

    }
}
