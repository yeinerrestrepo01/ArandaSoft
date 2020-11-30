using Common;
using DataAccesLayer;
using Entities;
using System.Linq;
using Entities.DTO;
using System.Collections.Generic;

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

        public ApiResult Login(UsuariosLogin Usuario)
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
                RolesRolId = t.RolesRolId,
            }).FirstOrDefault();

            if (UsuerValidation == null)
            {
                _ApiResult.IsError = true;
                _ApiResult.Message = Messages.LoginError;
            }
            else
            {
                UsuerValidation.ListPermission = new List<RoleAccionesDto>();
                UsuerValidation.ListPermission.AddRange(PermissionUser(Usuario.Usuario));
                _ApiResult.Result = UsuerValidation;
            }
            return _ApiResult;
        }

        public List<RoleAccionesDto> PermissionUser(string Usuario) 
        {
            var PermissionUser = (from usuario in _ArandaSoftContext.Usuarios
                                  join rolaccion in _ArandaSoftContext.RolAcciones on usuario.RolesRolId equals rolaccion.RolesRolId
                                  join accion in _ArandaSoftContext.Acciones on rolaccion.AccionesId equals accion.Id
                                  where usuario.Usuario == Usuario
                                  select new RoleAccionesDto
                                  {
                                      Descripcion = accion.Descripcion,
                                      Router = rolaccion.Router
                                  }).ToList();

            return PermissionUser;
        }
    }
}
