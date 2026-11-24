
using system_books.Models;

namespace system_books.Services
{
    public class UsuarioService
    {
        // Colección dinámica de usuarios
        private List<Usuario> usuarios = new List<Usuario>();

        // Agregar un usuario
        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        // Eliminar un usuario por su ID
        public bool EliminarUsuario(int id)
        {
            Usuario? usuario = BuscarPorId(id);

            if (usuario != null)
            {
                usuarios.Remove(usuario);
                return true;
            }

            return false;
        }

        // Obtener todos los usuarios
        public List<Usuario> ObtenerTodos()
        {
            return new List<Usuario>(usuarios);
        }

        // Buscar usuario por ID
        public Usuario? BuscarPorId(int id)
        {
            return usuarios.FirstOrDefault(usuario =>
                usuario.Id == id);
        }

        // Buscar usuarios por nombre
        public List<Usuario> BuscarPorNombre(string nombre)
        {
            return usuarios.Where(usuario =>
                usuario.Nombre.Contains(
                    nombre,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Buscar usuarios por apellido
        public List<Usuario> BuscarPorApellido(string apellido)
        {
            return usuarios.Where(usuario =>
                usuario.Apellido.Contains(
                    apellido,
                    StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Buscar usuarios por correo
        public Usuario? BuscarPorCorreo(string correo)
        {
            return usuarios.FirstOrDefault(usuario =>
                usuario.Correo.Equals(
                    correo,
                    StringComparison.OrdinalIgnoreCase));
        }

        // Ordenar usuarios por nombre
        public List<Usuario> OrdenarPorNombre()
        {
            return usuarios
                .OrderBy(usuario => usuario.Nombre)
                .ThenBy(usuario => usuario.Apellido)
                .ToList();
        }

        // KPI: cantidad total de usuarios
        public int ObtenerTotalUsuarios()
        {
            return usuarios.Count;
        }

        // KPI: cantidad de usuarios activos
        public int ObtenerUsuariosActivos()
        {
            return usuarios.Count(usuario => usuario.Activo);
        }

        // KPI: cantidad de usuarios inactivos
        public int ObtenerUsuariosInactivos()
        {
            return usuarios.Count(usuario => !usuario.Activo);
        }
    }
}
