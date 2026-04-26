namespace NutricionEnTusManos_1.Models
{
    public class Usuario
    {
        // Bloque 1: Identificación
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        // Bloque 2: Mediciones e Información Física
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public double PesoInicial { get; set; }
        public double PesoMeta { get; set; }

        // Bloque 3: Hábitos y Objetivos
        public string NivelActividad { get; set; }
        public string Objetivo { get; set; }
        public string TipoDieta { get; set; }

        // Constructor vacío (necesario para JSON)
        public Usuario() { }

        // Constructor para Login básico
        public Usuario(string nombreUsuario, string contrasena)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }

        // Constructor completo
        public Usuario(string nombreUsuario, string contrasena, double peso, double altura,
                       int edad, string nivelActividad, string objetivo, string tipoDieta)
        {
            Id = 0;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Peso = peso;
            Altura = altura;
            Edad = edad;
            PesoInicial = peso; // al registrarse el peso inicial = peso actual
            PesoMeta = objetivo == "Perder Peso" ? peso - 10 :
                       objetivo == "Ganar Masa" ? peso + 10 : peso;
            NivelActividad = nivelActividad;
            Objetivo = objetivo;
            TipoDieta = tipoDieta;
        }
    }
}