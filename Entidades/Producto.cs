namespace Entidades;

public class Producto
{
    public int Id { get; set; }
    public string descripcion { get; set; }
    public double costo { get; set; }
    public double precioVenta { get; set; }
    public int stock { get; set; }
    public int IdUsuario { get; set; }

    //public Producto(int id, string descripcion, double costo, double precioVenta, int stock, int idUsuario)
    //{
    //    this._Id = id;
    //    this._descripcion = descripcion;
    //    this._costo = costo;
    //    this._precioVenta = precioVenta;
    //    this._stock = stock;
    //    this._IdUsuario = idUsuario;
    //}

    //public int GetId() { return _Id; }
    //public string GetDescripcion() { return _descripcion; }
    //public double GetCosto() { return _costo; }
    //public double GetPrecioVenta() { return _precioVenta; }
    //public int GetStock() { return _stock; }
    //public int GetIdUsuario() { return _IdUsuario; }
}

