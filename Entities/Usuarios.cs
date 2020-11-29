using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(20)]
        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [MaxLength(60)]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(60)]
        public string Apellidos { get; set; }

        [Required]
        [MaxLength(60)]
        public string Direccion { get; set; }
        
        [MaxLength(10)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(60)]
        public string Email { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int RolesRolId { get; set; }
        public string Estado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaCreacion { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
