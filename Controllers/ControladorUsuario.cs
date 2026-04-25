using System.Collections.Generic;
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
    }
}