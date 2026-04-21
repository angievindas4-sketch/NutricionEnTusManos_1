using NutricionEnTusManos_1.Controllers.Estrategias;

namespace NutricionEnTusManos_1.Controllers
{
    // SOLID (SRP): Esta clase solo coordina la lógica de nutrición.
    public class ControladorNutricion
    {
        private CalculadoraNutricional? _calculadora;

        public string ObtenerPlan(int opcion, double peso, int edad)
        {
            IEstrategiaNutricion estrategiaSeleccionada;

            // El controlador decide qué estrategia inyectar al modelo (Strategy Pattern)
            switch (opcion)
            {
                case 1:
                    estrategiaSeleccionada = new EstrategiaPerderPeso();
                    break;
                case 2:
                    estrategiaSeleccionada = new EstrategiaGanarMasa();
                    break;
                default:
                    return "Opción no válida.";
            }

            // Usamos el contexto del modelo
            _calculadora = new CalculadoraNutricional(estrategiaSeleccionada);

            // Retornamos el informe que genera el modelo
            return _calculadora.GenerarInforme(peso, edad);
        }
    }
}