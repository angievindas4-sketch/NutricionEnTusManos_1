namespace NutricionEnTusManos_1.Controllers.Estrategias
{
    public class CalculadoraNutricional
    {
        private readonly IEstrategiaNutricion _estrategia;

        public CalculadoraNutricional(IEstrategiaNutricion estrategia)
        {
            _estrategia = estrategia;
        }

        public string Calcular(double peso, int edad)
        {
            double resultado = _estrategia.CalcularCalorias(peso, edad);
            return $"OBJETIVO: {_estrategia.ObtenerNombreObjetivo()}\n" +
                   $"CALORÍAS: {resultado} kcal\n" +
                   $"CONSEJO: {_estrategia.ObtenerRecomendacion()}";
        }
    }
}