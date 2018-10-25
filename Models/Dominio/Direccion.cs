using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dominio
{
    public class Direccion
    {
		public int direccionId { get; set; }
		public int usuarioId { get; set; }
		public string calle { get; set; }
		public int numero { get; set; }
		public int piso { get; set; }
		public string dpto { get; set; }
		public bool eliminado { get; set; }
		public DateTime? fechaEliminacion { get; set; }

	}
}
