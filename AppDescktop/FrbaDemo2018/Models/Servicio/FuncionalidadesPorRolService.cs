using Models.Base;
using Models.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.Servicio
{
    public class FuncionalidadesPorRolService
    {	
		//Se realiza el alta de una nueva funcionalidad mediante un objeto
		public int agregarFuncionalidadPorRol(FuncionalidadPorRol funcionalidadPorRol)
		{
			try
			{
				DaoObject dao = new DaoObject();
				return dao.Guardar(funcionalidadPorRol);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public List<int> getFuncionalidadesPorRol(int rolId) {
			try
			{
				DaoSP dao = new DaoSP();
				DataTable dt = new DataTable();
				List<int> resp = new List<int>();
				dt = dao.ObtenerDatosSP("getFuncionalidadPorRol",rolId);
				int res = 0;
				foreach (DataRow row in dt.Rows)
				{
					foreach (DataColumn column in dt.Columns)
					{
						res = int.Parse(row[column].ToString());
						resp.Add(res);
					}
				}
				return resp;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
