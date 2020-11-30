using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class RoleAccionesDto
    {
        public int Id { get; set; }
        public int RolesRolId { get; set; }
        public int AccionesId { get; set; }
        public string Router { get; set; }
        public string Descripcion { get; set; }
    }
}
