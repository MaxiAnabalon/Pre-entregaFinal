using Data.DataAccess;
using Entidades;

namespace Bussiness.Services;

public class ProductosServices
{
    private ProductosDB _productosDataAccess;

    public ProductosServices (ProductosDB ProductosDataAccess) 
    {   
        _productosDataAccess = ProductosDataAccess;
    }

    public Producto? OneProductoSer(int Id)
    {
        return _productosDataAccess.OneProducto(Id);

    }
    public List<Producto> GetProductosSer()
    {
        return _productosDataAccess.GetProductos() ;
    }

    public void UpdateProductoSer(int Id, Producto producto)
    {
        _productosDataAccess.UpdateProducto(Id, producto);   
    }

    public void InsertProductoSer(Producto producto)
    {
        _productosDataAccess.InsertProducto(producto);
    }
    public void DeleteProductoSer(int Id)
    {
        _productosDataAccess.DeleteProducto(Id);
    }


}

