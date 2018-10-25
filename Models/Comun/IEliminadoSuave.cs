using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Comun
{
    public interface IEliminadoSuave
    {
		bool Eliminado { get; set; }
		DateTime? FechaEliminacion { get; set; }
	}
}
