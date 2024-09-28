using Entidades;
using Data.Context;

namespace Data.DataAccess;

public class UsuarioDB
{
    private readonly DBConnection _conexion;

    // Constructor que utiliza la inyección de dependencias
    public UsuarioDB(DBConnection conexion)
    {
        _conexion = conexion;
    }

    public Usuario? OneUsuario(int Id)
    {
        return _conexion.Usuarios.FirstOrDefault(usu => usu.Id == Id);

    }
    public List<Usuario> GetUsuarios() 
    {
        return _conexion.Usuarios.ToList();
    }

    public void UpdateUsuario(int Id, Usuario usuario)
    {
        var usuarioEditar = OneUsuario(Id);
        if (usuarioEditar != null)
        {
            usuarioEditar.nombre = usuario.nombre;
            usuarioEditar.apellido = usuario.apellido;
            usuarioEditar.nombreDeUsuario = usuario.nombreDeUsuario;
            usuarioEditar.contraseña = usuario.contraseña;
            usuarioEditar.email = usuario.email; //nose si se tiene que cambiar?
        }
        _conexion.SaveChanges();
    }

    public void InsertUsuario(Usuario usuario)
    {
        _conexion.Usuarios.Add(usuario);
        _conexion.SaveChanges();
    }
    public void DeleteUsuario(int Id)
    {
        var usuarioAEliminar = OneUsuario(Id);
        if (usuarioAEliminar != null)
        {
            _conexion.Usuarios.Remove(usuarioAEliminar);
            _conexion.SaveChanges();
        }
    }
}
