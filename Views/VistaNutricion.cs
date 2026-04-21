using System;
using NutricionEnTusManos_1.Controllers;

namespace NutricionEnTusManos_1.Views
{
    public class VistaNutricion
    {
        private readonly ControladorNutricion _controlador = new ControladorNutricion();

        public void MostrarModulo()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("      BIENVENIDO AL MÓDULO NUTRICIONAL");
            Console.WriteLine("========================================");

            try
            {
                Console.Write("Ingrese su peso (kg): ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nElija su objetivo:");
                Console.WriteLine("1. Perder Peso");
                Console.WriteLine("2. Ganar Masa Muscular");
                Console.Write("Selección: ");
                int opcion = Convert.ToInt32(Console.ReadLine() ?? "0");

                // Pedimos el resultado al controlador
                string resultado = _controlador.ObtenerPlan(opcion, peso, edad);

                Console.WriteLine("\n" + resultado);
            }
            catch (Exception)
            {
                Console.WriteLine("\nError: Por favor ingrese datos numéricos válidos.");
            }

            Console.WriteLine("\nPresione cualquier tecla para volver...");
            Console.ReadKey();
        }
    }
}