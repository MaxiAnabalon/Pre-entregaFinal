using Data.DataAccess;
using Entidades;

namespace Bussiness.Services;
public class VentasServices 
{
    private VentaDB _ventasDataAccess;

    public VentasServices (VentaDB ventasDataAccess) 
    {
        _ventasDataAccess = ventasDataAccess;
    }
    public Venta? OneVentaSer(int Id)
    {
        return _ventasDataAccess.OneVenta(Id);

    }
    public List<Venta> GetVentasSer()
    {
        return _ventasDataAccess.GetVentas();
    }

    public void UpdateUsuarioSer(int Id, Venta venta)
    {  
        _ventasDataAccess.UpdateUsuario(Id, venta); 
    }

    public void InsertVentaSer(Venta venta)
    {
        _ventasDataAccess.InsertVenta(venta);
    }

    public void DeleteVentaSer(int Id)
    {
        _ventasDataAccess.DeleteVenta(Id);  
    }
}
