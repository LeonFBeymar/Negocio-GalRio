using System.ComponentModel.DataAnnotations;

namespace NegocioGalRio_API.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set;}
        public string? Descripcion { get; set; }
    }
}
