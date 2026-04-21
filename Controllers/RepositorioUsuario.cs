using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    // SOLID (SRP): Solo se encarga de la persistencia de datos.
    public class RepositorioUsuarios
    {
        private readonly string _rutaArchivo = "usuarios.json";

        public void GuardarTodo(List<Usuario> usuarios)
        {
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
    }
}