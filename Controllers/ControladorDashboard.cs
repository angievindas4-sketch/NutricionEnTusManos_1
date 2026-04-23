using System;
using System.Collections.Generic;
using System.Linq;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorDashboard
    {
        private readonly RepositorioMenu _repoMenu;
        private readonly RepositorioProducto _repoProductos;
        private Usuario _usuarioActual;

        public ControladorDashboard(Usuario usuario)
        {
            _usuarioActual = usuario;
            _repoMenu = new RepositorioMenu();
            _repoProductos = new RepositorioProducto();
        }

        // 1. Obtener el perfil del usuario para el bloque 1
        public Usuario ObtenerPerfil() => _usuarioActual;

        // 2. Obtener lo que el usuario ha comido HOY para el bloque 3
        public List<MenuDiario> ObtenerConsumoHoy()
        {
            var todoElHistorial = _repoMenu.ObtenerTodos();
            return todoElHistorial
                .Where(m => m.NombreUsuario == _usuarioActual.NombreUsuario &&
                            m.Fecha.Date == DateTime.Today)
                .ToList();
        }

        // 3. Calcular totales para el bloque 2 (Macros y Progreso)
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

        // 4. Buscar alimentos para el bloque 4 (Gestión)
        public List<Producto> BuscarAlimentos(string filtro)
        {
            var todos = _repoProductos.ObtenerTodos();
            return todos.Where(p => p.Nombre.ToLower().Contains(filtro.ToLower())).ToList();
        }
    }
}