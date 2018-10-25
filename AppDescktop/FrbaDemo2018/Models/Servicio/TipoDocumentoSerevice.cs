using Models.Base;
using Models.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.Servicio
{
    public class TipoDocumentoSerevice
    {
		public List<tipoDocumento> obtenerTiposDocumentosList()
		{
			try
			{
				DaoObject dao = new DaoObject();
				return dao.ObtenerListadoDeObjetos<tipoDocumento>();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public DataTable obtenerTiposDocumentosDt()
		{
			try
			{
				DaoSP dao = new DaoSP();
				DataTable dt = new DataTable();
				dt= dao.ObtenerDatosSP("getTipoDocumentos");
				return dt;
			}
			catch (Exception ex)
			{ throw ex; }
		}
	}
}
