using System.Collections.Generic;
using System.Linq;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorLogin
    {
        private List<Usuario> _listaUsuarios;
        private readonly ControladorUsuario _gestorUsuario;

        public ControladorLogin()
        {
            _gestorUsuario = new ControladorUsuario();
            _listaUsuarios = _gestorUsuario.CargarUsuarios();
        }

        /// <summary>
        /// Devuelve el objeto Usuario completo si las credenciales son correctas, null si no
        /// </summary>
        public Usuario ObtenerUsuario(string nombre, string contrasena)
        {
            // Recarga siempre del archivo para tener datos actualizados
            _listaUsuarios = _gestorUsuario.CargarUsuarios();
            return _listaUsuarios.FirstOrDefault(u =>
                u.NombreUsuario == nombre &&
                u.Contrasena == contrasena);
        }

        /// <summary>
        /// Valida si las credenciales existen en el sistema
        /// </summary>
        public bool ValidarLogin(string nombre, string contrasena)
        {
            // Recarga siempre del archivo para tener datos actualizados
            _listaUsuarios = _gestorUsuario.CargarUsuarios();
            return _listaUsuarios.Any(u =>
                u.NombreUsuario == nombre &&
                u.Contrasena == contrasena);
        }

        /// <summary>
        /// Registra un usuario completo con todos sus datos de perfil
        /// </summary>
        public bool Registrar(Usuario nuevoUsuario)
        {
            // Recarga para verificar datos más recientes antes de registrar
            _listaUsuarios = _gestorUsuario.CargarUsuarios();

            if (_listaUsuarios.Any(u => u.NombreUsuario == nuevoUsuario.NombreUsuario))
                return false;

            _listaUsuarios.Add(nuevoUsuario);
            _gestorUsuario.GuardarUsuarios(_listaUsuarios);
            return true;
        }
    }
}