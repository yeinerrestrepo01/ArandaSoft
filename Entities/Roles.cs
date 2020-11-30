using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId { get; set; }
        public string Nombre { get; set; }
        
        [MaxLength(1)]
        public string Estado { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
        public virtual ICollection<RolAcciones> RolaAcciones { get; set; }

    }
}
