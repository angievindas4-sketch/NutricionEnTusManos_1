namespace NutricionEnTusManos_1.Controllers.Estrategias
{
    // SOLID (D): Inversión de Dependencias. 
    // Definimos qué debe hacer cualquier estrategia nutricional.
    public interface IEstrategiaNutricion
    {
        string ObtenerNombreObjetivo();
        double CalcularCaloriasRecomendadas(double peso, int edad);
        string ObtenerRecomendacion();
    }
}