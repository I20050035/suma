﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resultado;
            Console.WriteLine("Ingrese un número Entero: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número Entero: ");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.WriteLine("Numero 1 + Numero 2 es igual: " + resultado);
            Console.ReadLine();
        }
    }
}
