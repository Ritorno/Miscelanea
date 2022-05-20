using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g
{
    internal class operadores
    {

      
        public static void operaciones()
        {
            int a;
            int b;
            int c;
            char ej1;
            Console.WriteLine("Bienvenido al menu");
            Console.WriteLine("------------------");
            Console.WriteLine(" Elija 1 si desea ver el Area de un triangulo");
            Console.WriteLine(" Elija 2 si desea hacer una suma ");
            Console.WriteLine(" Elija 3 si desea hacer una Potencia al cuadrado");
            Console.WriteLine(" Elija 4 si desea hacer una Conversion euros a dolares");
            Console.WriteLine(" Elija 5 si desea un algoritmo que muestre el valor del area y el perimetro de un cuadrardo con el lado de un cuadrado.");
            Console.WriteLine(" Elija 6 si desea Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
            Console.WriteLine(" Elija 7 si desea un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y el area del circulo inscrito");
            Console.WriteLine(" Elija 8 si desea Calcular el promedio de tres números ingresados por teclado.");
            Console.WriteLine(" Elija 0 si desea salir del programa"); 
            ej1 = char.Parse(Console.ReadLine());
            switch (ej1)
            {
                case '1': Art(); break;
                case '2': Sum(); break;
                case '3': Pot(); break;
                case '4': Con(); break;
                case '5': Cuadrado(); break;
                case '6': Cilindro(); break;
                case '7': Circulo(); break;
                case '8': promedio(); break;
                case '0': Environment.Exit(1); break;
                default: break;
            }
        }
        static void Art()

        {
            int a;
            int b;
            int area;
           
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

           
            Console.WriteLine("Por favor, digite la base del triangulo");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ahora, por favor, digite la altura");
            a = Convert.ToInt32(Console.ReadLine());
            area = b * a / 2;
            Console.WriteLine("El area del tringulo es: " + area);

        }

        static void Sum()
        {
            int n1;
            int n2;
            int total;

            try
            {
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Por favor digite el primer numero para realizar la suma");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor digite el segundo numero para completar la suma");
            n2 = Convert.ToInt32(Console.ReadLine());
            total = n1 * n2;
            Console.WriteLine("El resultado de la suma es: " + total);

        }
        static void Pot()
        {
            int numero1;
            int total;

            try
            {
                numero1 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Por favor digite un numero para saber el cuadrado");
            numero1 = Convert.ToInt32(Console.ReadLine());
            total = numero1 * numero1;
            Console.WriteLine("El resultado de la potencia es: " + total);


        }

        static void Con()

        {
            float e;
            float d;

            try
            {
                e = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite el numero en Euros");
            e = Convert.ToSingle(Console.ReadLine());
            d = (float)(e * 1.0831);
            Console.WriteLine(e + " en doloares es " + d);
        }


        static void Cuadrado()
        {
            int lado;
            int p;
            int a;

            try
            {
                lado = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite la medida de un lado del cuadrado");
            lado = Convert.ToInt32(Console.ReadLine());
            p = lado * 4;
            a = lado * lado;
            Console.WriteLine("El perimetro de su cuadrado es: " + p);
            Console.WriteLine("El area de su cuadrado es: " + a);


        }
        static void Cilindro()
        {
            int area;
            int volumen;
            int radio;
            int altura;

            try
            {
                radio = int.Parse(Console.ReadLine());
                altura = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite el radio de su cilindro");
            radio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la altura del cilindro");
            altura = Convert.ToInt32(Console.ReadLine());
            area = (int)(System.Math.PI * 2 * radio + altura + System.Math.PI * 2 * radio * radio);
            volumen = ((int)(System.Math.PI * radio * radio * altura));
            Console.WriteLine("El area de su cilindro es: " + area);
            Console.WriteLine("El volumen de su cilindro es " + volumen);

        }
        static void Circulo()
        {
            int radio;
            int area;
            int longitud;

            try
            {
                radio = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite el radio de la circunferencia");
            radio = Convert.ToInt32(Console.ReadLine());
            longitud = (int)(radio * 2 * System.Math.PI);
            area = (int)(System.Math.PI * radio * radio);
            Console.WriteLine("El area del circulo es: " + area);
            Console.WriteLine("La longitud de la circunferencia es: " + longitud);
        }
        static void promedio()
        {
            int datos;
            int d2;
            int d3;
            int promedio;

            try
            {
                datos = int.Parse(Console.ReadLine());
                d2 = int.Parse(Console.ReadLine());
                d3 = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡caracter no admitido!");
            }

            Console.WriteLine("Digite 3 numeros enteros para saber su promedio");
            Console.WriteLine("Digite el primer numero");
            datos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            d2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el tercer numero");
            d3 = Convert.ToInt32(Console.ReadLine());
            promedio = datos + d2 + d3 / 3;
            Console.WriteLine("El promedio de sus numeros es: " + promedio);

        }
        public static void Bucles()
        {
            Console.WriteLine("Seccion en proceso");
        }

        

                public static void Arreglos()
        {
            Console.WriteLine("Seccion en proceso");
        }

    }
}
 
