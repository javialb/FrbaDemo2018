using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dominio
{
    public class RolesPorUsuario
    {
		public string nombreRol { get; set; }
		public int usuarioId { get; set; }
		public bool habilitado { get; set; }

	}
}
