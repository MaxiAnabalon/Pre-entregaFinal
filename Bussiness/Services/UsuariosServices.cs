using Data.DataAccess;
using Entidades;

namespace Bussiness.Services;

public class UsuariosServices
{
    private UsuarioDB _usuariosServicesDataAccess;

    public UsuariosServices(UsuarioDB usuariosServicesDataAccess) 
    {
        _usuariosServicesDataAccess = usuariosServicesDataAccess;
    }

    public Usuario? OneUsuarioSer(int Id)
    {
        return _usuariosServicesDataAccess.OneUsuario(Id);
    }
    public List<Usuario> GetUsuariosSer()
    {
        return _usuariosServicesDataAccess.GetUsuarios();
    }

    public void UpdateUsuarioSer(int Id, Usuario usuario)
    {
        _usuariosServicesDataAccess.UpdateUsuario(Id, usuario); 
    }

    public void InsertUsuarioSer(Usuario usuario)
    {
        _usuariosServicesDataAccess.InsertUsuario(usuario);
    }
    public void DeleteUsuarioSer(int Id)
    {
        _usuariosServicesDataAccess?.DeleteUsuario(Id); 
    }

}

