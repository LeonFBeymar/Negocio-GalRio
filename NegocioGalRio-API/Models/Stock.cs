using System.ComponentModel.DataAnnotations;

namespace NegocioGalRio_API.Models
{
    public class Stock
    {
        public int IdStock { get; set; }
        public string? Notas { get; set; }
        public int Estado { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
