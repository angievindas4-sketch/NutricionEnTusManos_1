using System;
using System.Collections.Generic;
using System.Linq;
using NutricionEnTusManos_1.Datos;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    /// <summary>
    /// Controlador encargado de la gestión del menú diario del usuario
    /// </summary>
    public class ControladorMenu
    {
        private readonly RepositorioMenu _repositorio;
        private readonly Usuario _usuarioActual;

        public ControladorMenu(Usuario usuario)
        {
            _usuarioActual = usuario;
            _repositorio = new RepositorioMenu();
        }

        /// <summary>
        /// Obtiene los alimentos de un tiempo de comida específico en una fecha
        /// </summary>
        public List<Producto> ObtenerAlimentosPorTiempo(DateTime fecha, string tiempoComida)
        {
            var historial = _repositorio.ObtenerTodos();
            var registro = historial.FirstOrDefault(m =>
                m.NombreUsuario == _usuarioActual.NombreUsuario &&
                m.Fecha.Date == fecha.Date &&
                m.TiempoComida == tiempoComida);

            return registro?.Alimentos ?? new List<Producto>();
        }

        /// <summary>
        /// Agrega un alimento a un tiempo de comida en una fecha específica
        /// </summary>
        public void AgregarAlimento(DateTime fecha, string tiempoComida, Producto producto)
        {
            var historial = _repositorio.ObtenerTodos();
            var registro = historial.FirstOrDefault(m =>
                m.NombreUsuario == _usuarioActual.NombreUsuario &&
                m.Fecha.Date == fecha.Date &&
                m.TiempoComida == tiempoComida);

            if (registro == null)
            {
                registro = new MenuDiario
                {
                    NombreUsuario = _usuarioActual.NombreUsuario,
                    Fecha = fecha.Date,
                    TiempoComida = tiempoComida,
                    Alimentos = new List<Producto>()
                };
                historial.Add(registro);
            }

            registro.Alimentos.Add(producto);
            _repositorio.GuardarTodos(historial);
        }

        /// <summary>
        /// Elimina un alimento de un tiempo de comida en una fecha específica
        /// </summary>
        public void EliminarAlimento(DateTime fecha, string tiempoComida, string nombreAlimento)
        {
            var historial = _repositorio.ObtenerTodos();
            var registro = historial.FirstOrDefault(m =>
                m.NombreUsuario == _usuarioActual.NombreUsuario &&
                m.Fecha.Date == fecha.Date &&
                m.TiempoComida == tiempoComida);

            if (registro == null) return;

            var alimento = registro.Alimentos.FirstOrDefault(a => a.Nombre == nombreAlimento);
            if (alimento != null)
            {
                registro.Alimentos.Remove(alimento);
                _repositorio.GuardarTodos(historial);
            }
        }

        /// <summary>
        /// Obtiene todos los menús del usuario en una fecha específica
        /// </summary>
        public List<MenuDiario> ObtenerMenuDelDia(DateTime fecha)
        {
            var historial = _repositorio.ObtenerTodos();
            return historial
                .Where(m => m.NombreUsuario == _usuarioActual.NombreUsuario &&
                            m.Fecha.Date == fecha.Date)
                .ToList();
        }

        /// <summary>
        /// Calcula el total de calorías consumidas en una fecha
        /// </summary>
        public double CalcularTotalCaloriasDelDia(DateTime fecha)
        {
            var menus = ObtenerMenuDelDia(fecha);
            return menus.SelectMany(m => m.Alimentos).Sum(a => a.Calorias);
        }
    }
}