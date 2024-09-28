using Entidades;
using Data.Context;

namespace Data.DataAccess;

public class ProductoVendidoDB
{
    private readonly DBConnection _conexion;

    public ProductoVendidoDB(DBConnection conexion)
    {
        _conexion = conexion;
    }

    public ProductoVendido? OneProductoVendido(int Id)
    {
        return _conexion.ProductosVendidos.FirstOrDefault(pro => pro.Id == Id);
    }
    public List<ProductoVendido> GetProductoVendido()
    {
        return _conexion.ProductosVendidos.ToList();
    }

    public void UpdateProductoVendido(int Id, ProductoVendido productoVend)
    {
        var productoEditarVend = OneProductoVendido(Id);
        if (productoEditarVend != null)
        {
            productoEditarVend.IdProducto = productoVend.IdProducto; //nose si se tiene que cambiar?   
            productoEditarVend.stock = productoVend.stock;
            productoEditarVend.IdVenta = productoVend.IdVenta; //nose si se tiene que cambiar?
        }
        _conexion.SaveChanges();
    }

    public void InsertProductosVendido(ProductoVendido productoVend)
    {
        _conexion.ProductosVendidos.Add(productoVend);
        _conexion.SaveChanges();
    }
    public void DeleteProductoVendido(int Id)
    {
        var productoAEliminarVend = OneProductoVendido(Id);
        if (productoAEliminarVend != null)
        {
            _conexion.ProductosVendidos.Remove(productoAEliminarVend);
            _conexion.SaveChanges();
        }
    }
}

