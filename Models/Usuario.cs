namespace NutricionEnTusManos_1.Models
{
    // POO: Definimos la clase 'Usuario' (Entidad de datos)
    public class Usuario
    {
        // CLEAN CODE: Nombres en español claros y descriptivos.
        // POO (Encapsulamiento): Propiedades para proteger el acceso a los datos.

        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        // Constructor: Inicializa el objeto con los datos requeridos.
        // Según tu dibujo: Username y Pasword.
        public Usuario(string nombreUsuario, string contrasena)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
        }
    }
}