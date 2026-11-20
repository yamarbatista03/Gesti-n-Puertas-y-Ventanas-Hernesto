public class EstrategiaPuertaBatiente : IEstrategiaCalculo
{
    public decimal CalcularCosto(decimal alto, decimal ancho, decimal precioBaseMaterial)
    {
        decimal area = alto * ancho;
        decimal costoMaterial = area * precioBaseMaterial;
        decimal herrajesReforzados = 1500m; // Cerradura y bisagras pesadas
        decimal manoObra = costoMaterial * 0.35m; // 35% mano de obra
        return costoMaterial + herrajesReforzados + manoObra;
    }
}
