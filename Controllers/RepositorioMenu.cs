using System;
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
            try
            {
                if (!File.Exists(_rutaArchivo)) return new List<MenuDiario>();

                string json = File.ReadAllText(_rutaArchivo);
                return JsonSerializer.Deserialize<List<MenuDiario>>(json) ?? new List<MenuDiario>();
            }
            catch
            {
                return new List<MenuDiario>();
            }
        }

        // Cambiamos el nombre a GuardarTodos para eliminar el error CS1061
        public void GuardarTodos(List<MenuDiario> historial)
        {
            try
            {
                var opciones = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(historial, opciones);
                File.WriteAllText(_rutaArchivo, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el menú: " + ex.Message);
            }
        }
    }
}