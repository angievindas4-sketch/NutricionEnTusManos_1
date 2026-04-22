using NutricionEnTusManos_1.Controllers.Estrategias;

public class EstrategiaGanarMasa : IEstrategiaNutricion
{
    public double CalcularCalorias(double peso, int edad) => peso * 35;
    public string ObtenerNombreObjetivo() => "GANAR MASA MUSCULAR";
    public string ObtenerRecomendacion() => "Aumente el consumo de proteínas y realice entrenamiento de fuerza.";
}