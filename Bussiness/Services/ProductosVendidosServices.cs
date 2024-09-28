using Data.DataAccess;
using Entidades;

namespace Bussiness.Services;

public class ProductosVendidosServices
{
    private ProductoVendidoDB _productosVendidosDataAccess;

    public ProductosVendidosServices (ProductoVendidoDB productoVendidoDataAccess) 
    {
        _productosVendidosDataAccess = productoVendidoDataAccess;
    }

    public ProductoVendido? OneProductoVendidoSer(int Id)
    {
        return _productosVendidosDataAccess.OneProductoVendido(Id);
    }
    public List<ProductoVendido> GetProductosVendidosSer()
    {   
       return _productosVendidosDataAccess.GetProductoVendido();
    }

    public void UpdateProductoVendidoSer(int Id, ProductoVendido productoVend)
    {
        _productosVendidosDataAccess.UpdateProductoVendido(Id, productoVend);
    }

    public void InsertProductosVendidoSer(ProductoVendido productoVend)
    {
        _productosVendidosDataAccess.InsertProductosVendido(productoVend);
    }
    public void DeleteProductoVendidoSer(int Id)
    {
        _productosVendidosDataAccess.DeleteProductoVendido(Id);
    }
}

