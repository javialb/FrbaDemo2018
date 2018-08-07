using Models.Comun;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dominio
{
    public class Funcionalidad:IEliminadoSuave
    {
		public int FuncionalidadId { get; set; }
		public string FuncionalidadDescripcion { get; set; }
		public bool Habilitado { get; set; }
		public bool Eliminado { get; set; }
		public DateTime? FechaEliminacion { get; set; }
	}
}
