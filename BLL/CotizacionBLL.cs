using System;

public class CotizacionBLL
{
    private IEstrategiaCalculo _estrategia;

    public void DefinirTipoProducto(IEstrategiaCalculo estrategia)
    {
        _estrategia = estrategia;
    }

    public decimal GenerarPresupuesto(decimal alto, decimal ancho, decimal precioBase)
    {
        if (alto <= 0 || ancho <= 0)
            throw new ArgumentException("Las dimensiones deben ser mayores a cero.");

        return _estrategia.CalcularCosto(alto, ancho, precioBase);
    }
}
