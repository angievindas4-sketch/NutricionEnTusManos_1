using NutricionEnTusManos_1.Models.Estrategias;

namespace NutricionEnTusManos_1.Models
{
    public class CalculadoraNutricional
    {
        // POO: Composición. La calculadora "tiene una" estrategia.
        private IEstrategiaNutricion _estrategia;

        // El constructor recibe cualquier clase que implemente la interfaz
        public CalculadoraNutricional(IEstrategiaNutricion estrategia)
        {
            _estrategia = estrategia;
        }

        // Permite cambiar la estrategia en tiempo de ejecución
        public void CambiarEstrategia(IEstrategiaNutricion nuevaEstrategia)
        {
            _estrategia = nuevaEstrategia;
        }

        public string GenerarInforme(double peso, int edad)
        {
            double calorias = _estrategia.CalcularCaloriasRecomendadas(peso, edad);
            return $"--- PLAN: {_estrategia.ObtenerNombreObjetivo()} ---\n" +
                   $"Calorías diarias: {calorias} kcal\n" +
                   $"Recomendación: {_estrategia.ObtenerRecomendacion()}";
        }
    }
}