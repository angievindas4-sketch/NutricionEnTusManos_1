using System;
using NutricionEnTusManos_1.Controllers;

namespace NutricionEnTusManos_1.Views
{
    public class VistaLogin
    {
        private readonly ControladorLogin _controladorLogin = new ControladorLogin();

        // CAMBIO: Inicializamos con string.Empty para evitar la advertencia CS8618
        private string UsuarioInput { get; set; } = string.Empty;
        private string PasswordInput { get; set; } = string.Empty;

        public void MostrarMenuPrincipal()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("   NUTRICIÓN EN TUS MANOS - LOGIN");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Iniciar Sesión (Validar)");
                Console.WriteLine("2. Registrarse (Registro)");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");

                // CAMBIO: Agregamos ?? "" para asegurar que nunca sea nulo
                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        Validar();
                        break;
                    case "2":
                        Registro();
                        break;
                    case "3":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void Validar()
        {
            Console.Clear();
            Console.WriteLine("--- INICIO DE SESIÓN ---");
            Console.Write("Usuario: ");
            // CAMBIO: Controlamos el posible nulo con ?? ""
            UsuarioInput = Console.ReadLine() ?? "";
            Console.Write("Contraseña: ");
            PasswordInput = Console.ReadLine() ?? "";

            if (_controladorLogin.ValidarLogin(UsuarioInput, PasswordInput))
            {
                Console.WriteLine("\n¡Acceso concedido! Bienvenido.");
                Console.WriteLine("Presione una tecla para entrar al sistema de nutrición...");
                Console.ReadKey();
                // Aquí llamaremos al Strategy después
            }
            else
            {
                Console.WriteLine("\nError: Usuario o contraseña incorrectos.");
                Console.ReadKey();
            }
        }

        public void Registro()
        {
            Console.Clear();
            Console.WriteLine("--- REGISTRO DE NUEVO USUARIO ---");
            Console.Write("Cree su nombre de usuario: ");
            UsuarioInput = Console.ReadLine() ?? "";
            Console.Write("Cree su contraseña: ");
            PasswordInput = Console.ReadLine() ?? "";

            if (_controladorLogin.Registrar(UsuarioInput, PasswordInput))
            {
                Console.WriteLine("\n¡Registro exitoso! Ya puede iniciar sesión.");
            }
            else
            {
                Console.WriteLine("\nEl usuario ya existe. Intente con otro nombre.");
            }
            Console.ReadKey();
        }
    }
}