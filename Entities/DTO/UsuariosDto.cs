﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class UsuariosDto
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int RolesRolId { get; set; }
        public string Estado { get; set; }
        public string Rol { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
