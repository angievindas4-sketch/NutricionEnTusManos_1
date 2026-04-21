namespace NutricionEnTusManos_1.Models.Estrategias
{
    public class EstrategiaPerderPeso : IEstrategiaNutricion
    {
        public string ObtenerNombreObjetivo() => "Perder Peso (Déficit Calórico)";

        public double CalcularCaloriasRecomendadas(double peso, int edad)
            => (peso * 22) - 500; // Ejemplo de fórmula simple

        public string ObtenerRecomendacion()
            => "Prioriza proteínas y vegetales. Realiza ejercicio cardiovascular.";
    }
}
