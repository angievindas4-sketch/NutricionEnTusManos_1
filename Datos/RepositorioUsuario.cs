using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Datos
{
    // SOLID (SRP): Solo se encarga de la persistencia de datos.
    public class RepositorioUsuarios
    {
        private readonly string _rutaArchivo = "usuarios.json";

        public void GuardarTodo(List<Usuario> usuarios)
        {
            // Asigna ID automático a usuarios que no tienen uno
            int proximoId = usuarios.Any() ? usuarios.Max(u => u.Id) + 1 : 1;
            foreach (var usuario in usuarios.Where(u => u.Id == 0))
            {
                usuario.Id = proximoId++;
            }

            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(usuarios, opciones);
            File.WriteAllText(_rutaArchivo, json);
        }

        public List<Usuario> ObtenerTodos()
        {
            if (!File.Exists(_rutaArchivo)) return new List<Usuario>();

            string json = File.ReadAllText(_rutaArchivo);
            return JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();
        }

        /// <summary>
        /// Busca un usuario por nombre de usuario y contraseña (para login)
        /// </summary>
        public Usuario? BuscarPorCredenciales(string nombreUsuario, string contrasena)
        {
            return ObtenerTodos()
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario
                                  && u.Contrasena == contrasena);
        }
    }
}