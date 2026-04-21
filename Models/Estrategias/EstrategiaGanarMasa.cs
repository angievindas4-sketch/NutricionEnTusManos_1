namespace NutricionEnTusManos_1.Models.Estrategias
{
    public class EstrategiaGanarMasa : IEstrategiaNutricion
    {
        public string ObtenerNombreObjetivo() => "Ganar Masa Muscular (Superávit)";

        public double CalcularCaloriasRecomendadas(double peso, int edad)
            => (peso * 22) + 500;

        public string ObtenerRecomendacion()
            => "Aumenta el consumo de carbohidratos complejos y entrena fuerza.";
    }
}