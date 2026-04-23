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

        public bool ValidarLogin(string nombre, string contrasena)
        {
            return _listaUsuarios.Any(u => u.NombreUsuario == nombre && u.Contrasena == contrasena);
        }

        public bool Registrar(string nombre, string contrasena)
        {
            if (_listaUsuarios.Any(u => u.NombreUsuario == nombre)) return false;

            // Usamos el constructor vacío y asignamos lo básico
            Usuario nuevo = new Usuario
            {
                NombreUsuario = nombre,
                Contrasena = contrasena
            };

            _listaUsuarios.Add(nuevo);
            _gestorUsuario.GuardarUsuarios(_listaUsuarios);
            return true;
        }
    }
}