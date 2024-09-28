using Entidades;
using Data.Context;

namespace Data.DataAccess;
public class VentaDB
{
    private readonly DBConnection _conexion;

    // Constructor que utiliza la inyección de dependencias
    public VentaDB(DBConnection conexion)
    {
        _conexion = conexion;
    }

    public Venta? OneVenta(int Id)
    {
        return _conexion.ventas.FirstOrDefault(ven => ven.Id == Id);

    }
    public List<Venta> GetVentas()
    {
        return _conexion.ventas.ToList();
    }

    public void UpdateUsuario(int Id, Venta venta)
    {
        var ventaEditar = OneVenta(Id);
        if (ventaEditar != null)
        {
            ventaEditar.Id = venta.Id;
            ventaEditar.comentario = venta.comentario;
            ventaEditar.IdUsuario = venta.IdUsuario;
        }
        _conexion.SaveChanges();
    }

    public void InsertVenta(Venta venta)
    {
        _conexion.ventas.Add(venta);
        _conexion.SaveChanges();
    }
    public void DeleteVenta(int Id)
    {
        var ventaAEliminar = OneVenta(Id);
        if (ventaAEliminar != null)
        {
            _conexion.ventas.Remove(ventaAEliminar);
            _conexion.SaveChanges();
        }
    }
}

