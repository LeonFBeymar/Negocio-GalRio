using System.ComponentModel.DataAnnotations;

namespace NegocioGalRio_API.Models
{
    public class Producto
    {
        public int IdProducto  {get; set;}
        public string? Codigo  {get; set;}
	    public string? Nombre {get; set;}
        public string? Descripcion  {get; set;}
	    public decimal? Precio  {get; set;}
        public string? Marca  {get; set;}
        public Categoria? IdCategoria  {get; set;}
	    public Stock? IdStock { get; set; }
    }
}
