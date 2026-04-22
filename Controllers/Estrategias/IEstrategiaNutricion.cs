namespace NutricionEnTusManos_1.Controllers.Estrategias
{
    public interface IEstrategiaNutricion
    {
        string ObtenerNombreObjetivo();
        double CalcularCalorias(double peso, int edad);
        string ObtenerRecomendacion();
    }
}