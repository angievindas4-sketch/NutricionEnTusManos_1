namespace NutricionEnTusManos_1.Controllers.Estrategias
{
    public interface IEstrategiaNutricion
    {
        // Debemos declarar los 3 métodos aquí para que la calculadora pueda verlos
        double CalcularCalorias(double peso, int edad);
        string ObtenerNombreObjetivo();
        string ObtenerRecomendacion();
    }
}