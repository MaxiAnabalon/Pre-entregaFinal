namespace Entidades;

public class ProductoVendido
{

    public int Id { get; set; }
    public int IdProducto { get; set; }
    public int stock { get; set; }
    public int IdVenta { get; set; }


    //public ProductoVendido(int id, int idProducto, int stock, int IdVenta)
    //{
    //    this._Id = id;
    //    this._IdProducto = idProducto;
    //    this._stock = stock;
    //    this._IdVenta = IdVenta;
    //}

    //public int GetId() { return _Id; }
    //public int GetIdProducto() { return _IdProducto; }
    //public double GetStock() { return _stock; }
    //public int GetIdVenta() { return _IdVenta; }
}

