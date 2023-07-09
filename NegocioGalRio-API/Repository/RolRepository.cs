using NegocioGalRio_API.Contexts;
using NegocioGalRio_API.Models;

namespace NegocioGalRio_API.Repository
{
    public class RolRepository
    {
        private readonly ConectionSQLServer context;
        public RolRepository(ConectionSQLServer context)
        {
            this.context = context;
        }
        
        public IEnumerable<Rol> Get()
        {
            return context.Rol.ToArray();
        }
    }
}
