using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NutricionEnTusManos_1.Datos;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorDashboard
    {
        private readonly RepositorioMenu _repoMenu;
        private readonly RepositorioProducto _repoProductos;
        private Usuario _usuarioActual;

        // Meta calórica diaria base (se puede hacer dinámica después)
        private const double MetaCaloriasDiaria = 2000;

        public ControladorDashboard(Usuario usuario)
        {
            _usuarioActual = usuario;
            _repoMenu = new RepositorioMenu();
            _repoProductos = new RepositorioProducto();
        }

        // 1. Obtener el perfil del usuario
        public Usuario ObtenerPerfil() => _usuarioActual;

        // 2. Obtener consumo de hoy
        public List<MenuDiario> ObtenerConsumoHoy()
        {
            var todoElHistorial = _repoMenu.ObtenerTodos();
            return todoElHistorial
                .Where(m => m.NombreUsuario == _usuarioActual.NombreUsuario &&
                            m.Fecha.Date == DateTime.Today)
                .ToList();
        }

        // 3. Calcular totales de macros de hoy
        public (double cal, double prot, double carb, double grasa) CalcularTotalesHoy()
        {
            var comidasHoy = ObtenerConsumoHoy();
            double tCal = 0, tProt = 0, tCarb = 0, tGrasa = 0;

            foreach (var menu in comidasHoy)
            {
                tCal += menu.Alimentos.Sum(a => a.Calorias);
                tProt += menu.Alimentos.Sum(a => a.Proteinas);
                tCarb += menu.Alimentos.Sum(a => a.Carbohidratos);
                tGrasa += menu.Alimentos.Sum(a => a.Grasas);
            }

            return (tCal, tProt, tCarb, tGrasa);
        }

        // 4. Buscar alimentos por filtro
        public List<Producto> BuscarAlimentos(string filtro)
        {
            var todos = _repoProductos.ObtenerTodos();
            if (string.IsNullOrEmpty(filtro)) return new List<Producto>();
            return todos.Where(p => p.Nombre.ToLower().Contains(filtro.ToLower())).ToList();
        }

        // 5. Agregar alimento al menú de hoy
        public void AgregarAlimentoAlMenu(Producto producto)
        {
            var historial = _repoMenu.ObtenerTodos();
            var registroHoy = historial.FirstOrDefault(m =>
                m.NombreUsuario == _usuarioActual.NombreUsuario &&
                m.Fecha.Date == DateTime.Today);

            if (registroHoy == null)
            {
                registroHoy = new MenuDiario
                {
                    NombreUsuario = _usuarioActual.NombreUsuario,
                    Fecha = DateTime.Today,
                    Alimentos = new List<Producto>()
                };
                historial.Add(registroHoy);
            }

            registroHoy.Alimentos.Add(producto);
            _repoMenu.GuardarTodos(historial);
        }

        // 6. Calcular IMC del usuario actual
        public double CalcularIMC()
        {
            if (_usuarioActual.Altura <= 0) return 0;
            double alturaMetros = _usuarioActual.Altura / 100.0;
            return _usuarioActual.Peso / (alturaMetros * alturaMetros);
        }

        // 7. Obtener estado del IMC en texto
        public string ObtenerEstadoIMC(double imc)
        {
            if (imc < 18.5) return "Bajo peso";
            if (imc < 25.0) return "Normal";
            if (imc < 30.0) return "Sobrepeso";
            return "Obesidad";
        }

        // 8. Obtener color del semáforo según IMC
        public Color ObtenerColorIMC(double imc)
        {
            if (imc < 18.5) return Color.DodgerBlue;
            if (imc < 25.0) return Color.LimeGreen;
            if (imc < 30.0) return Color.Orange;
            return Color.Red;
        }

        // 9. Obtener porcentaje de calorías consumidas hoy vs meta
        public double ObtenerPorcentajeCaloriasHoy()
        {
            var totales = CalcularTotalesHoy();
            return (totales.cal / MetaCaloriasDiaria) * 100;
        }
    }
}