using System.ComponentModel.DataAnnotations;

namespace NegocioGalRio_API.Models
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string? Nombre { get; set;}
        public string? Descripcion { get; set; }
    }
}
