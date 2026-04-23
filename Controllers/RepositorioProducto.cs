using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class RepositorioProducto
    {
        private readonly string _rutaArchivo = "productos.json";

        public List<Producto> ObtenerTodos()
        {
            if (!File.Exists(_rutaArchivo)) return new List<Producto>();

            string json = File.ReadAllText(_rutaArchivo);
            return JsonSerializer.Deserialize<List<Producto>>(json) ?? new List<Producto>();
        }

        public void GuardarTodo(List<Producto> productos)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(productos, opciones);
            File.WriteAllText(_rutaArchivo, json);
        }
    }
}