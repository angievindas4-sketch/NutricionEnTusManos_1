using NutricionEnTusManos_1.Controllers.Estrategias;

public class EstrategiaPerderPeso : IEstrategiaNutricion
{
    public double CalcularCalorias(double peso, int edad) => peso * 22;
    public string ObtenerNombreObjetivo() => "PERDER PESO";
    public string ObtenerRecomendacion() => "Realice déficit calórico y aumente el ejercicio aeróbico.";
}