using System.Collections.Generic;
using System.Linq;
using NutricionEnTusManos_1.Datos;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorUsuario
    {
        private readonly RepositorioUsuarios _repositorio = new RepositorioUsuarios();

        public List<Usuario> CargarUsuarios() => _repositorio.ObtenerTodos();

        public void GuardarUsuarios(List<Usuario> lista) => _repositorio.GuardarTodo(lista);

        /// <summary>
        /// Registra un nuevo usuario verificando que el nombre no exista ya
        /// </summary>
        public bool RegistrarUsuario(Usuario nuevoUsuario)
        {
            var usuarios = _repositorio.ObtenerTodos();
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
        /// Actualiza los datos de un usuario existente preservando PesoInicial
        /// </summary>
        public bool ActualizarUsuario(Usuario usuarioActualizado)
        {
            var usuarios = _repositorio.ObtenerTodos();
            var existente = usuarios.FirstOrDefault(u => u.NombreUsuario == usuarioActualizado.NombreUsuario);

            if (existente == null) return false;

            // Si es la primera vez que se guarda, preservar el peso inicial
            if (existente.PesoInicial == 0)
                existente.PesoInicial = existente.Peso;

            existente.Peso = usuarioActualizado.Peso;
            existente.Altura = usuarioActualizado.Altura;
            existente.Edad = usuarioActualizado.Edad;
            existente.Sexo = usuarioActualizado.Sexo;
            existente.NivelActividad = usuarioActualizado.NivelActividad;
            existente.Objetivo = usuarioActualizado.Objetivo;
            existente.TipoDieta = usuarioActualizado.TipoDieta;
            existente.PesoMeta = usuarioActualizado.PesoMeta;

            _repositorio.GuardarTodo(usuarios);
            return true;
        }
    }
}