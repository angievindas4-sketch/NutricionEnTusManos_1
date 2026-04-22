using NutricionEnTusManos_1.Controllers.Estrategias;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorNutricion
    {
        private CalculadoraNutricional? _calculadora;

        public string ObtenerPlan(int opcion, double peso, int edad)
        {
            IEstrategiaNutricion estrategia;

            // Selección de la estrategia según la opción de la vista
            switch (opcion)
            {
                case 1:
                    estrategia = new EstrategiaMantenerPeso();
                    break;
                case 2:
                    estrategia = new EstrategiaPerderPeso();
                    break;
                case 3:
                    estrategia = new EstrategiaGanarMasa();
                    break;
                default:
                    return "Opción de objetivo no válida.";
            }

            // Se inicializa la calculadora con la estrategia elegida
            _calculadora = new CalculadoraNutricional(estrategia);

            // Se ejecuta el cálculo y se devuelve el texto
            return _calculadora.Calcular(peso, edad);
        }
    }
}