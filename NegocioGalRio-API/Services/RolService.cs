using NegocioGalRio_API.Models;
using NegocioGalRio_API.Repository;

namespace NegocioGalRio_API.Services
{
    public class RolService
    {
        private readonly RolRepository _rolRepository;
        public RolService(RolRepository rolRepository) {
            _rolRepository = rolRepository;
        }
        public IEnumerable<Rol> GetRol()
        {
            return _rolRepository.Get();    
        }
    }
}
