using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class RolAcciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RolesRolId { get; set; }
        public int AccionesId { get; set; }

        public virtual Roles Roles { get; set; }
        public virtual Acciones Accione { get; set; }
    }
}
