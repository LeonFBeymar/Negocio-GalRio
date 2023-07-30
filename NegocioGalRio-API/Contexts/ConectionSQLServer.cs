using Microsoft.EntityFrameworkCore;
using NegocioGalRio_API.Models;
using System.Text;

namespace NegocioGalRio_API.Contexts
{
    public class ConectionSQLServer:DbContext
    {
        public ConectionSQLServer(DbContextOptions<ConectionSQLServer> options) : base(options) 
        {
            //
        }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        
        //Esto es por si se ocurre modificar la configuracion para conectarse con la db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        #region configuracion Models
        //Esto es para configurar los Models, ejemplo haciendo que la PK sea lo señalado
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsRequired();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength (250)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasMaxLength(50)
                    .IsRequired()
                    .IsUnicode(false);

            });
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode (false)
                    .IsRequired();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .IsRequired();
            });
            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.DNI);

                entity.Property (e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsRequired();

            });
            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.IdStock);

                entity.Property(e => e.Notas)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.PrecioVenta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.PrecioCompra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired();

            });
                
        }
        #endregion
    }
}
