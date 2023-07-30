using NegocioGalRio_API.Models;
using NegocioGalRio_API.Repository;
using NegocioGalRio_API.ViewModel;
using AutoMapper;
namespace NegocioGalRio_API.Services
{
    public class RolService
    {
        private readonly RolRepository _rolRepository;
        public readonly IMapper mapper;
        public RolService(RolRepository rolRepository, IMapper mapper)
        {
            _rolRepository = rolRepository;
            this.mapper = mapper;
        }
        public Rol GetRol(int Id)
        {
            return _rolRepository.GetRol().First(x => x.IdRol == Id);    
        }

        public void SetRol(RolViewModel rol)
        {
            var erroresValidacion = new List<string>();
            try
            {
                if(rol == null) {
                    erroresValidacion.Add("No hay datos ingresados");
                }
                else
                {
                    if (string.IsNullOrEmpty(rol.Nombre)) {
                        erroresValidacion.Add("No se ingreso un nombre para el rol");
                    }
                    else
                    {
                        Rol rol_ = mapper.Map<Rol>(rol); 
                        _rolRepository.SetRol(rol_);
                    }
                }
                if(erroresValidacion.Count > 0)
                {
                    throw new Exception($"Error/es: {string.Join(" ", erroresValidacion)}");
                }
            }
            catch (Exception)
            {
                throw new Exception(message:"Ocurrio un error inesperado");
            }
        }
    }
}
