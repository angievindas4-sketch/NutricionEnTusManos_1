using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class RepositorioMenu
    {
        private readonly string _rutaArchivo = "historial_consumo.json";

        public List<MenuDiario> ObtenerTodos()
        {
            if (!File.Exists(_rutaArchivo)) return new List<MenuDiario>();

            string json = File.ReadAllText(_rutaArchivo);
            return JsonSerializer.Deserialize<List<MenuDiario>>(json) ?? new List<MenuDiario>();
        }

        public void GuardarTodo(List<MenuDiario> historial)
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(historial, opciones);
            File.WriteAllText(_rutaArchivo, json);
        }
    }
}