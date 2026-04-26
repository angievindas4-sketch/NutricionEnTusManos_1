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

        private double MetaCaloriasDiaria => CalcularMetaCalorias();

        private double CalcularMetaCalorias()
        {
            double tmb;
            if (_usuarioActual.Sexo == "Masculino")
                tmb = 10 * _usuarioActual.Peso + 6.25 * _usuarioActual.Altura - 5 * _usuarioActual.Edad + 5;
            else
                tmb = 10 * _usuarioActual.Peso + 6.25 * _usuarioActual.Altura - 5 * _usuarioActual.Edad - 161;

            double factor = _usuarioActual.NivelActividad switch
            {
                "Sedentario" => 1.2,
                "Ligero (1-3 días/semana)" => 1.375,
                "Moderado (3-5 días/semana)" => 1.55,
                "Activo (6-7 días/semana)" => 1.725,
                "Muy activo (atleta)" => 1.9,
                _ => 1.2
            };

            double tdee = tmb * factor;

            return _usuarioActual.Objetivo switch
            {
                "Perder Peso" => tdee - 500,
                "Ganar Masa" => tdee + 300,
                _ => tdee
            };
        }

        /// <summary>
        /// Expone la meta calórica diaria calculada para uso en las vistas
        /// </summary>
        public double ObtenerMetaCaloriasDiaria() => MetaCaloriasDiaria;

        public ControladorDashboard(Usuario usuario)
        {
            _usuarioActual = usuario;
            _repoMenu = new RepositorioMenu();
            _repoProductos = new RepositorioProducto();
        }

        public Usuario ObtenerPerfil() => _usuarioActual;

        public List<MenuDiario> ObtenerConsumoHoy()
        {
            var todoElHistorial = _repoMenu.ObtenerTodos();
            return todoElHistorial
                .Where(m => m.NombreUsuario == _usuarioActual.NombreUsuario &&
                            m.Fecha.Date == DateTime.Today)
                .ToList();
        }

        public (double cal, double prot, double carb, double grasa) CalcularTotalesHoy()
        {
            var comidasHoy = ObtenerConsumoHoy();
            double tCal = 0, tProt = 0, tCarb = 0, tGrasa = 0;

            foreach (var menu in comidasHoy)
            {
                tCal += menu.Alimentos.Sum(a => a.Calorias * a.Cantidad);
                tProt += menu.Alimentos.Sum(a => a.Proteinas * a.Cantidad);
                tCarb += menu.Alimentos.Sum(a => a.Carbohidratos * a.Cantidad);
                tGrasa += menu.Alimentos.Sum(a => a.Grasas * a.Cantidad);
            }

            return (tCal, tProt, tCarb, tGrasa);
        }

        public List<Producto> BuscarAlimentos(string filtro)
        {
            var todos = _repoProductos.ObtenerTodos();
            if (string.IsNullOrEmpty(filtro)) return new List<Producto>();
            return todos.Where(p => p.Nombre.ToLower().Contains(filtro.ToLower())).ToList();
        }

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

        public double CalcularIMC()
        {
            if (_usuarioActual.Altura <= 0) return 0;
            double alturaMetros = _usuarioActual.Altura / 100.0;
            return _usuarioActual.Peso / (alturaMetros * alturaMetros);
        }

        public string ObtenerEstadoIMC(double imc)
        {
            if (imc < 18.5) return "Bajo peso";
            if (imc < 25.0) return "Normal";
            if (imc < 30.0) return "Sobrepeso";
            return "Obesidad";
        }

        public Color ObtenerColorIMC(double imc)
        {
            if (imc < 18.5) return Color.DodgerBlue;
            if (imc < 25.0) return Color.LimeGreen;
            if (imc < 30.0) return Color.Orange;
            return Color.Red;
        }

        public double ObtenerPorcentajeCaloriasHoy()
        {
            var totales = CalcularTotalesHoy();
            return (totales.cal / MetaCaloriasDiaria) * 100;
        }
    }
}