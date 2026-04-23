namespace NutricionEnTusManos_1.Models
{
    public class Usuario
    {
        // Bloque 1: Acceso
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        // Bloque 2: Mediciones e Información Física
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }

        // Bloque 3: Hábitos y Objetivos
        public string NivelActividad { get; set; }
        public string Objetivo { get; set; }
        public string TipoDieta { get; set; }

        // Constructor vacío (Necesario para JSON)
        public Usuario() { }

        // Constructor para Login/Registro básico (Para evitar errores en el código actual)
        public Usuario(string nombreUsuario, string contrasena)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }

        // Constructor completo para el perfil detallado
        public Usuario(string nombre, string pass, double peso, double altura, int edad, string nivel, string objetivo, string dieta)
        {
            NombreUsuario = nombre;
            Contrasena = pass;
            Peso = peso;
            Altura = altura;
            Edad = edad;
            NivelActividad = nivel;
            Objetivo = objetivo;
            TipoDieta = dieta;
        }
    }
}