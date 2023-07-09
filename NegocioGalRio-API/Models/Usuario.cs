using System.ComponentModel.DataAnnotations;

namespace NegocioGalRio_API.Models
{
    public class Usuario
    {
        public int DNI { get; set; }
        public string? Nombre { get; set;}
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Contraseña { get; set;}
        public Rol? Rol { get; set; }
    }
}
