using Common;
using DataAccesLayer;
using Entities;
using System.Linq;
using Entities.DTO;

namespace BusinessLogicLayer
{
    public class ManagerSecurity
    {
        private readonly ArandaSoftContext _ArandaSoftContext;
        private readonly ApiResult _ApiResult;
        public ManagerSecurity(ArandaSoftContext ArandaSoftContext) 
        {
            _ArandaSoftContext = ArandaSoftContext;
            _ApiResult = new ApiResult { IsError = false, Message = Messages.SuccesFullOperation };
        }

        public ApiResult Login(Usuarios Usuario)
        {
            var UsuerValidation = _ArandaSoftContext.Usuarios.Where(u => u.Usuario == Usuario.Usuario && 
            u.Password == Security.GetSHA256(Usuario.Password)).Select(t => new UsuariosDto
            {
                Nombres = t.Nombres,
                Apellidos = t.Apellidos,
                Direccion = t.Direccion,
                Telefono = t.Telefono,
                Email = t.Email,
                Rol = t.Roles.Nombre,
                Id = t.Id,
                Estado = t.Estado,
                FechaNacimiento = t.FechaNacimiento,
                Edad = t.Edad,
                Usuario = t.Usuario,
                RolesRolId = t.RolesRolId
            }).FirstOrDefault();

            if (UsuerValidation == null)
            {
                _ApiResult.IsError = true;
            }
            else
            {
                _ApiResult.Result = UsuerValidation;
            }
            return _ApiResult;
        }
    }
}
