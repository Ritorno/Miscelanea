using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g
{
    internal class main
    {
        public static void Main(string [] args)
        {

            Menus menus = new Menus();
            Menus.menus();

            operadores operadores = new operadores();
            operadores.operaciones();

            condicionales1 condicionales = new condicionales1();
            condicionales1.Condicionales();

        }
    }
}
