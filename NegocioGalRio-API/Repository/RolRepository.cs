using NegocioGalRio_API.Contexts;
using NegocioGalRio_API.Models;
using NegocioGalRio_API.ViewModel;

namespace NegocioGalRio_API.Repository
{
    public class RolRepository
    {
        private readonly ConectionSQLServer context;
        public RolRepository(ConectionSQLServer context)
        {
            this.context = context;
        }
        public IEnumerable<Rol> GetRol()
        {
            return context.Rol.ToArray();
        }

        public void SetRol(Rol rol) {
            context.Add(rol);
            context.SaveChanges();
        }
    }
}
