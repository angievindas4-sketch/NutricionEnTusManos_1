namespace NutricionEnTusManos_1.Controllers.Estrategias
{
    public class EstrategiaGanarMasa : IEstrategiaNutricion
    {
        public string ObtenerNombreObjetivo() => "Ganar Masa";
        public double CalcularCalorias(double peso, int edad) => (peso * 22) + 500;
        public string ObtenerRecomendacion() => "Superávit y pesas.";
    }
}