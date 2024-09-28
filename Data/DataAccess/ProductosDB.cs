using Entidades;
using Data.Context;


namespace Data.DataAccess;

public class ProductosDB
{
    
    private readonly DBConnection _conexion;

    // Constructor que utiliza la inyección de dependencias
    public ProductosDB(DBConnection conexion)
    {
        _conexion = conexion;
    }
    public  Producto? OneProducto(int Id)
    {
        return _conexion.Productos.FirstOrDefault(pro => pro.Id == Id);

    }
    public  List<Producto> GetProductos()
    {
        return _conexion.Productos.ToList();
    }

    public void UpdateProducto(int Id, Producto producto)
    {
        var productoEditar = OneProducto(Id);
        if (productoEditar != null)
        {
            productoEditar.descripcion = producto.descripcion;
            productoEditar.costo = producto.costo;
            productoEditar.precioVenta = producto.precioVenta;
            producto.stock = productoEditar.stock;
            producto.IdUsuario = producto.IdUsuario; //nose si se tiene que cambiar?
        }
        _conexion.SaveChanges();
    }

    public void InsertProducto(Producto producto)
    {
        _conexion.Productos.Add(producto);
        _conexion.SaveChanges();
    }
    public void DeleteProducto(int Id)
    {
        var productoAEliminar = OneProducto(Id);
        if (productoAEliminar != null)
        {
            _conexion.Productos.Remove(productoAEliminar);
            _conexion.SaveChanges();
        }
    }
   
}


