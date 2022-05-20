using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g
{
    internal class condicionales1
    {
        public static void Condicionales()
        {
            int gg;
            Console.WriteLine("Bienvenido a los condicionales");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Si desea saber si el numero que ingreso es positivo o negativo");
            Console.WriteLine("2. Si desea escribir 2 numeros y saber cual es menor y cual es mayor");
            Console.WriteLine("3. Si desea un programa que lea tres números enteros positivos y que calcule e imprima en pantalla el menor y el mayor de ellos.");
            Console.WriteLine("4. Si desea poner 2 numeros y si el primero es mayor sumarlo sino restarlos ");
            Console.WriteLine("5. Si desea elegir dos números A y B encontrar el cociente entre A y B.");
            Console.WriteLine("6. Si desea dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine("6. Si desea un algoritmo que deermine si un año es biciesto o no");
            gg = char.Parse(Console.ReadLine());
            switch (gg)
            {
                case '1': pos(); break;
                case '2': ej2(); break;
                case '3': ej3(); break;
                case '4': ej4(); break;
                case '5': ej5(); break;
                case '6': ej6(); break;
                case '7': ej7(); break;
                case '8':; break;
                case '0': Environment.Exit(1); break;
                default: break;
            }

        }
        public static void pos()
        {
            int a;

            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine(" digite un numero para saber si es positivo o negativo");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("su numero es negativo");

            }
            if (a > 0)
            {
                Console.WriteLine("su numero es positivo");
            }


        }
        public static void ej2()
        {
            int a;
            int b;

            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite 2 numeros enteros para saber cual es mayor y cual es menor");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine(a + " Es el numero menor ");
                Console.WriteLine(b + " Es el numero mayor");

            }
            if (b < a)
            {
                Console.WriteLine(b + " Es el numero menor");
                Console.WriteLine(a + " Es el numero mayor");
            }

        }
        public static void ej3()
        {
            int a;
            int b;
            int c;

            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite 3 numero enteros");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero");
            c = Convert.ToInt32(Console.ReadLine());
            if (a < b && a < c)
            {
                Console.WriteLine(a + " Es el numero mayor");

            }
            else if (b < c && b < a)
            {
                Console.WriteLine(b + " Es el numero mayor");

            }
            else
            {
                Console.WriteLine(c + " Es el numero mayor");
            }
            if (a > b && a > c)
            {
                Console.WriteLine(a + " Es el numero Menor");
            }
            else if (b > c && b > a)
            {
                Console.WriteLine(b + " Es el numero menor");
            }
            else
            {
                Console.WriteLine(c + " Es el numero menor");
            }

        }
        public static void ej4()
        {
            int a, b, r, r2;

            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite 2 numeros enteros");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            r = a + b;
            r2 = a - b;
            if (a > b)
            {
                Console.WriteLine("El resultado de la suma de los 2 numeros es: " + r);
            }
            else if (a < b)
            {
                Console.WriteLine("El resultado de la resta de los 2 numeros es: " + r2);
            }
        }
        public static void ej5()
        {
            int a, b, r, r2;

            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite 2 numeros enteeros para saber su cociente");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            r2 = a / b;
            if (a == 0 || b == 0)
            {
                Console.WriteLine("No se puede divir entre 0");
            }
            if (a < 0 || b < 0)
            {
                Console.WriteLine("El resultado de la division es: " + r2);
            }

        }
        public static void ej6()
        {
            int a;
            int b;
            int c;
            int r, r2;

            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite 3 numero enteros");
            Console.WriteLine("Digite el primer numero");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero");
            c = Convert.ToInt32(Console.ReadLine());
            r = a + b;
            r2 = a * b;
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Se va sumar sus numeros");
                Console.WriteLine("EL resultado de la suma es" + r);
            }
            else if (a > 0 || b > 0)
            {
                Console.WriteLine("Se van a multiplicar sus numeros" + r);
                Console.WriteLine("El resultado de la multiplicacion es " + r2);
            }
        }
        public static void ej7()
        {
            int a;

            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite un año para saber si es bisiesto");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
            {
                Console.WriteLine("Es bisiesto" + a);
            }
            else
            {
                Console.WriteLine("no es bisiesto " + a);
            }

        }



        public static void Arreglos()
        {
            Console.WriteLine("Seccion en proceso");
        }

    }
}
