﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO 01");
            Console.WriteLine("1 .- Declare 5 cinco variables primitivas numéricas");
            
            int numero;
            double decimal1;
            long numeromayor;
            float decima2;
            byte ip;

            Console.WriteLine("2 .- Declare 3 variables primitivas de tipo texto");

            char caracter;
            string cadena;
            bool falsoverdadero;

            Console.WriteLine("3 .- Declare 5 variables numéricas y asígneles un valor");

            int cantidad = 100;
            double decimal3 = 0.54321;
            long cantidadmayor = 50000000;
            float decimal4 = 10;
            byte ip1 = 255;

            Console.WriteLine("4.- Declare 3 variables de texto e ingrese un valor por teclado");

            Console.WriteLine("5.- Ingrese valores numéricos por teclado y muéstrelos en consola con la frase “El número que ingreso es: ”");
            Console.WriteLine("6.- Realice 5 ejemplos de conversión implícita");
            Console.WriteLine("7.- Realice 5 ejemplos de conversión explicita");
            Console.WriteLine("8.- Ingrese dos números por teclado y verifique cual es el mayor y cual el menor");
            Console.WriteLine("9.- Ingrese un numero por teclado y verifique si es par");
            Console.WriteLine("10.- Ingrese un numero por teclado y verifique si es múltiplo de 3, 5 o 7");
        }
    }
}
