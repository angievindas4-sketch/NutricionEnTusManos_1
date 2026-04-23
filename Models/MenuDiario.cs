using System;
using System.Collections.Generic;

namespace NutricionEnTusManos_1.Models
{
    public class MenuDiario
    {
        public string NombreUsuario { get; set; } // Para saber de quién es el menú
        public DateTime Fecha { get; set; }
        public string TiempoComida { get; set; } // Desayuno, Almuerzo, etc.
        public List<Producto> Alimentos { get; set; } = new List<Producto>();

        public MenuDiario() { }
    }
}