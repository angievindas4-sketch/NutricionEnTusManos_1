using NutricionEnTusManos_1.Controllers.Estrategias;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorNutricion
    {
        private CalculadoraNutricional? _calculadora;

        public string ObtenerPlan(int opcion, double peso, int edad)
        {
            IEstrategiaNutricion estrategia;

            if (opcion == 1)
                estrategia = new EstrategiaPerderPeso();
            else
                estrategia = new EstrategiaGanarMasa();

            _calculadora = new CalculadoraNutricional(estrategia);
            return _calculadora.Calcular(peso, edad);
        }
    }
}