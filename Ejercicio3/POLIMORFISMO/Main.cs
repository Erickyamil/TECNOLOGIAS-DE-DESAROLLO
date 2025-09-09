﻿using System;
using System.Collections.Generic;
using PolimorfismoDemo.Figuras;
using PolimorfismoDemo.Genericos;
using PolimorfismoDemo.Utilidades;
using PolimorfismoDemo.Unidades;

namespace PolimorfismoDemo
{
    class Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Polimorfismo en C# ===");

            // 🔹 Inclusión (Dinámico)
            List<Figura> figuras = new List<Figura>
            {
                new Circulo(5),
                new Rectangulo(4, 6)
            };

            foreach (var f in figuras)
            {
                f.Dibujar();
                Console.WriteLine($"Área: {f.CalcularArea()}");
            }

            // 🔹 Paramétrico (Genéricos)
            Caja<string> caja1 = new Caja<string>();
            caja1.Guardar("Hola");
            Console.WriteLine($"Caja contiene: {caja1.Obtener()}");

            Caja<int> caja2 = new Caja<int>();
            caja2.Guardar(42);
            Console.WriteLine($"Caja contiene: {caja2.Obtener()}");

            // 🔹 Sobrecarga
            Calculadora calc = new Calculadora();
            Console.WriteLine($"Suma int: {calc.Sumar(3,4)}");
            Console.WriteLine($"Suma double: {calc.Sumar(3.5,4.2)}");

            // 🔹 Coerción
            Metro m = 10.5;              // implícita
            double d = (double)m;        // explícita
            Console.WriteLine($"Metro: {m.Valor}, convertido a double: {d}");
        }
    }
}