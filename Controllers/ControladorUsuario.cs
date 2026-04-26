using System.Collections.Generic;
using System.Linq;
using NutricionEnTusManos_1.Datos;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorUsuario
    {
        private readonly RepositorioUsuarios _repositorio = new RepositorioUsuarios();

        // Carga la lista desde el repositorio
        public List<Usuario> CargarUsuarios() => _repositorio.ObtenerTodos();

        // Envía la lista al repositorio para ser guardada
        public void GuardarUsuarios(List<Usuario> lista) => _repositorio.GuardarTodo(lista);

        /// <summary>
        /// Registra un nuevo usuario verificando que el nombre no exista ya
        /// </summary>
        public bool RegistrarUsuario(Usuario nuevoUsuario)
        {
            var usuarios = _repositorio.ObtenerTodos();

            // Verifica que el nombre de usuario no esté en uso
            bool yaExiste = usuarios.Any(u => u.NombreUsuario == nuevoUsuario.NombreUsuario);
            if (yaExiste) return false;

            usuarios.Add(nuevoUsuario);
            _repositorio.GuardarTodo(usuarios);
            return true;
        }

        /// <summary>
        /// Valida credenciales para el login
        /// </summary>
        public Usuario Login(string nombreUsuario, string contrasena)
        {
            return _repositorio.BuscarPorCredenciales(nombreUsuario, contrasena);
        }

        /// <summary>
        /// Actualiza los datos de un usuario existente
        /// </summary>
        public bool ActualizarUsuario(Usuario usuarioActualizado)
        {
            var usuarios = _repositorio.ObtenerTodos();
            var existente = usuarios.FirstOrDefault(u => u.NombreUsuario == usuarioActualizado.NombreUsuario);

            if (existente == null) return false;

            existente.Peso = usuarioActualizado.Peso;
            existente.Altura = usuarioActualizado.Altura;
            existente.Edad = usuarioActualizado.Edad;
            existente.Sexo = usuarioActualizado.Sexo;
            existente.NivelActividad = usuarioActualizado.NivelActividad;
            existente.Objetivo = usuarioActualizado.Objetivo;
            existente.TipoDieta = usuarioActualizado.TipoDieta;

            _repositorio.GuardarTodo(usuarios);
            return true;
        }
    }
}