using System.Collections.Generic;
using System.Linq;
using NutricionEnTusManos_1.Datos;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    /// <summary>
    /// Controlador encargado de la gestión del catálogo de alimentos
    /// </summary>
    public class ControladorAlimentos
    {
        private readonly RepositorioProducto _repositorio;

        public ControladorAlimentos()
        {
            _repositorio = new RepositorioProducto();
        }

        /// <summary>
        /// Obtiene todos los productos del catálogo
        /// </summary>
        public List<Producto> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }

        /// <summary>
        /// Busca productos por nombre
        /// </summary>
        public List<Producto> Buscar(string filtro)
        {
            var todos = _repositorio.ObtenerTodos();
            if (string.IsNullOrWhiteSpace(filtro))
                return todos;

            return todos
                .Where(p => p.Nombre.ToLower().StartsWith(filtro.ToLower()))
                .ToList();
        }

        /// <summary>
        /// Agrega un nuevo producto al catálogo
        /// </summary>
        public void AgregarProducto(Producto producto)
        {
            var todos = _repositorio.ObtenerTodos();
            todos.Add(producto);
            _repositorio.GuardarTodo(todos);
        }

        /// <summary>
        /// Elimina un producto por nombre
        /// </summary>
        public bool EliminarProducto(string nombre)
        {
            var todos = _repositorio.ObtenerTodos();
            var producto = todos.FirstOrDefault(p => p.Nombre == nombre);
            if (producto == null) return false;

            todos.Remove(producto);
            _repositorio.GuardarTodo(todos);
            return true;
        }

        /// <summary>
        /// Actualiza un producto existente
        /// </summary>
        public bool ActualizarProducto(Producto productoActualizado)
        {
            var todos = _repositorio.ObtenerTodos();
            var existente = todos.FirstOrDefault(p => p.Nombre == productoActualizado.Nombre);
            if (existente == null) return false;

            existente.UnidadMedida = productoActualizado.UnidadMedida;
            existente.Calorias = productoActualizado.Calorias;
            existente.Proteinas = productoActualizado.Proteinas;
            existente.Carbohidratos = productoActualizado.Carbohidratos;
            existente.Grasas = productoActualizado.Grasas;

            _repositorio.GuardarTodo(todos);
            return true;
        }
    }
}