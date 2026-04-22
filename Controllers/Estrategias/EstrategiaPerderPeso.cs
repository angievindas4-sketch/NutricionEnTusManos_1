namespace NutricionEnTusManos_1.Controllers.Estrategias
{
    public class EstrategiaPerderPeso : IEstrategiaNutricion
    {
        public string ObtenerNombreObjetivo() => "Perder Peso";
        public double CalcularCalorias(double peso, int edad) => (peso * 22) - 500;
        public string ObtenerRecomendacion() => "Déficit calórico y cardio.";
    }
}