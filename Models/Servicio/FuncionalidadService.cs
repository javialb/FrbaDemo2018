using Models.Base;
using Models.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.Servicio
{
    public class FuncionalidadService
	{	
		//Se realiza el alta de una nueva funcionalidad mediante un objeto
		public int agregarFuncionalidad(Funcionalidad funcionalidad)
		{
			try
			{
				DaoObject dao = new DaoObject();
				return dao.Guardar(funcionalidad);
			}
			catch (Exception ex)
			{throw ex;}
		}
		public int agregarFuncionalidades(List<Funcionalidad> funcionalidades)
		{
			try
			{
				int contador = 0;
				DaoObject dao = new DaoObject();
				foreach (var item in funcionalidades)
				{
					contador= contador +  dao.Guardar(item);
				}
				return contador;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public DataTable obtenerFuncionalidadesDT()
		{
			try
			{
				DaoSP daoSP = new DaoSP();
				return daoSP.ObtenerDatosSP("getFuncionalidades");
			}
			catch (Exception ex)
			{throw ex;}
		}
		//Permite la modificacion de un rol mediante un Query
		public int modificarFuncionalidad(Funcionalidad funcionalidad)
		{
			try
			{
				DaoObject dao = new DaoObject();
				return dao.Modificar(funcionalidad);
			}
			catch (Exception ex)
			{throw ex;}
		}
		//Permite la eliminacion (lógica) de un rol mediante un Query
		public int eliminarFuncionalidadLog(int id)
		{
			try
			{
				DaoObject dao = new DaoObject();
				Funcionalidad funcionalidad = new Funcionalidad();
				funcionalidad = dao.ObtenerUnObjeto<Funcionalidad>(id);
				funcionalidad.Eliminado = true;
				funcionalidad.FechaEliminacion = DateTime.Now;
				return dao.Modificar(funcionalidad);
			}
			catch (Exception ex)
			{throw ex;}
		}
	}
}
