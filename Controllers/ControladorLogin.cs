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
            // Refrescamos la lista siempre al iniciar para tener datos actuales del JSON
            _listaUsuarios = _gestorUsuario.CargarUsuarios();
        }

        // NUEVO MÉTODO: Devuelve el objeto Usuario completo si existe, o null si no.
        public Usuario ObtenerUsuario(string nombre, string contrasena)
        {
            // Buscamos en la lista el usuario que coincida con ambos datos
            return _listaUsuarios.FirstOrDefault(u => u.NombreUsuario == nombre && u.Contrasena == contrasena);
        }

        public bool ValidarLogin(string nombre, string contrasena)
        {
            return _listaUsuarios.Any(u => u.NombreUsuario == nombre && u.Contrasena == contrasena);
        }

        public bool Registrar(string nombre, string contrasena)
        {
            if (_listaUsuarios.Any(u => u.NombreUsuario == nombre)) return false;

            Usuario nuevo = new Usuario
            {
                NombreUsuario = nombre,
                Contrasena = contrasena,
                // Valores por defecto para nuevos registros
                Peso = 0,
                Altura = 0,
                Objetivo = "No definido"
            };

            _listaUsuarios.Add(nuevo);
            _gestorUsuario.GuardarUsuarios(_listaUsuarios);
            return true;
        }
    }
}