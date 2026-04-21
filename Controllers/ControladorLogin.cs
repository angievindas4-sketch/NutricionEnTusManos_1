using System.Collections.Generic;
using System.Linq;
using NutricionEnTusManos_1.Models;

namespace NutricionEnTusManos_1.Controllers
{
    public class ControladorLogin
    {
        // Atributo solicitado en tu dibujo: "user list"
        private List<Usuario> _listaUsuarios;
        private readonly ControladorUsuario _gestorUsuario;

        public ControladorLogin()
        {
            _gestorUsuario = new ControladorUsuario();
            // Al iniciar el controlador, cargamos los datos existentes
            _listaUsuarios = _gestorUsuario.CargarUsuarios();
        }

        // Requisito: validateLogin()
        public bool ValidarLogin(string nombre, string contrasena)
        {
            // Buscamos si existe un usuario con esos datos exactos
            return _listaUsuarios.Any(u => u.NombreUsuario == nombre && u.Contrasena == contrasena);
        }

        // Requisito: register()
        public bool Registrar(string nombre, string contrasena)
        {
            // Clean Code: Validamos que el nombre no esté repetido
            if (_listaUsuarios.Any(u => u.NombreUsuario == nombre)) return false;

            // Creamos la instancia (POO) y la añadimos a la lista
            Usuario nuevo = new Usuario(nombre, contrasena);
            _listaUsuarios.Add(nuevo);

            // Persistimos los cambios
            _gestorUsuario.GuardarUsuarios(_listaUsuarios);
            return true;
        }
    }
}