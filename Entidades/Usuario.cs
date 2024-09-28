namespace Entidades;
public class Usuario
{
    public int Id { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string nombreDeUsuario { get; set; }
    public string contraseña { get; set; }
    public string email { get; set; }

    //public Usuario(int id, string nombre, string apellido, string nombreDeUsuario, string contraseña, string email)
    //{
    //    this._id = id;
    //    this._nombre = nombre;
    //    this._apellido = apellido;
    //    this._nombreDeUsuario = nombreDeUsuario;
    //    this._contraseña = contraseña;
    //    this._email = email;
    //}

    //public int GetId() { return _id; }

    //public string GetNombre() { return _nombre; }
    //public string GetApellido() { return _apellido; }

    //public string GetNombreUsuario() { return _nombreDeUsuario; }
    //public string GetContraseña() { return _contraseña; }

    //public string GetEmail() { return _email; }
}

