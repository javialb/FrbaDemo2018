using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Dominio
{
    public class tipoDocumento
	{
		public int tipoDocumentoId { get; set; }
		public string descripcion { get; set; }
		public bool habilitado { get; set; }
	}
}
