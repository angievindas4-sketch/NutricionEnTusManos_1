namespace NutricionEnTusManos_1.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string UnidadMedida { get; set; } // ej: "100g", "1 unidad", "250ml"
        public double Calorias { get; set; }
        public double Proteinas { get; set; }
        public double Carbohidratos { get; set; }
        public double Grasas { get; set; }

        public Producto() { }

        public Producto(string nombre, string unidad, double cal, double prot, double carb, double grasa)
        {
            Nombre = nombre;
            UnidadMedida = unidad;
            Calorias = cal;
            Proteinas = prot;
            Carbohidratos = carb;
            Grasas = grasa;
        }
    }
}