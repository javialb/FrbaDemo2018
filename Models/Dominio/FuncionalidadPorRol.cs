using Models.Comun;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dominio
{
    public class FuncionalidadPorRol : IEliminadoSuave
	{
		#region atributos
		public int FuncionalidadPorRolId { get; set; }
		public int rolId { get; set; }
		public int funcionalidadId { get; set; }
		public bool habilitado { get; set; }
		public bool Eliminado { get; set; }
		public DateTime? FechaEliminacion { get; set; }
		//private string usr = "''";
		#endregion
		public FuncionalidadPorRol()
		{
			this.Eliminado = false;
		}
	}
}
