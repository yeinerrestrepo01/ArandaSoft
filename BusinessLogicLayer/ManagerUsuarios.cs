using Common;
using DataAccesLayer;
using Entities;
using System;
using System.Linq;
using Entities.DTO;

namespace BusinessLogicLayer
{
    public class ManagerUsuarios : IDataRepository<Usuarios>
    {
        private readonly ArandaSoftContext ContextDb;
        private readonly ApiResult _ApiResult;
        public ManagerUsuarios(ArandaSoftContext ArandaSoftContext)
        {
            ContextDb = ArandaSoftContext;
            _ApiResult = new ApiResult { IsError = false, Message = Messages.SuccesFullOperation }; 
        }

        public ApiResult Add(Usuarios Entity)
        {
            ContextDb.Usuarios.Add(Entity);
            ContextDb.SaveChanges();
            return _ApiResult;
        }

        public ApiResult Delete(Usuarios Entity)
        {
            ContextDb.Usuarios.Remove(Entity);
            ContextDb.SaveChanges(); 
            return _ApiResult;
        }

        public ApiResult Get(object Id)
        {
            
            _ApiResult.Result = ContextDb.Usuarios
                  .FirstOrDefault(e => e.Id == Convert.ToInt32(Id));
            return _ApiResult;
        }

        public ApiResult GetAll()
        {
            _ApiResult.Result = ContextDb.Usuarios.Select
                (
                   t => new UsuariosDto
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
                   }
                ).ToList();
            return _ApiResult;
        }

        public ApiResult Update(int Id, Usuarios Entity)
        {
            var UsuarioNew = ContextDb.Usuarios
                  .FirstOrDefault(e => e.Id == Id);
            if (UsuarioNew == null)
            {
                _ApiResult.Message = Messages.SuccesFullOperation;
                _ApiResult.IsError = true;
            }
            else
            {
                 SetInformationUpdate(UsuarioNew,Entity);
                 ContextDb.SaveChanges();
            }
            return _ApiResult;
        }
        private void SetInformationUpdate(Usuarios  UsuarioNew, Usuarios Usuario)
        {
            UsuarioNew.Nombres = Usuario.Nombres; 
            UsuarioNew.Apellidos = Usuario.Apellidos; 
            UsuarioNew.Direccion = Usuario.Direccion; 
            UsuarioNew.Telefono = Usuario.Telefono;
        }
    }
}
