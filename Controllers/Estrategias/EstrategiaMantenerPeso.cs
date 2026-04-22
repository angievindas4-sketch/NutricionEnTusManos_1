using NutricionEnTusManos_1.Controllers.Estrategias;

public class EstrategiaMantenerPeso : IEstrategiaNutricion
{
    public double CalcularCalorias(double peso, int edad) => peso * 30;
    public string ObtenerNombreObjetivo() => "MANTENER PESO";
    public string ObtenerRecomendacion() => "Mantenga su equilibrio calórico y actividad física constante.";
}