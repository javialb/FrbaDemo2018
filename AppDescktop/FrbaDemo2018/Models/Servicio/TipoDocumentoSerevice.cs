using Models.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.Servicio
{
    public class TipoDocumentoSerevice
    {
		public DataTable obtenerTiposDocumentos()
		{
			try
			{
				DaoSP dao = new DaoSP();
				return dao.ObtenerDatosSP("getTipoDocumentos");
			}
			catch (Exception ex)
			{ throw ex; }
		}
	}
}
