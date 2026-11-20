public class EstrategiaVentanaCorrediza : IEstrategiaCalculo
{
    public decimal CalcularCosto(decimal alto, decimal ancho, decimal precioBaseMaterial)
    {
        decimal area = alto * ancho;
        decimal costoMaterial = area * precioBaseMaterial;
        decimal manoObra = costoMaterial * 0.25m; // 25% instalación y corte
        return costoMaterial + manoObra;
    }
}
