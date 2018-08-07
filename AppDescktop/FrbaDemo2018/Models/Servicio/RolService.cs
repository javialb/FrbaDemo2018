using Models.Base;
using Models.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.Servicio
{
    public class RolService
    {
		//Se realiza el alta de un nuevo rol mediante un objeto que se transforma en una query
		//public int agregarRol(Rol rol) {
		//	try
		//	{ DaoObject dao = new DaoObject();
		//		return dao.Guardar(rol); 
		//	}
		//	catch (Exception ex)
		//	{

		//		throw ex;
		//	}
		//}
		public int agregarRolSP(Rol rol)
		{
			try
			{
				DaoSP dao = new DaoSP();
				DataTable dt = new DataTable();
				 dt= dao.ObtenerDatosSP("RolAlta",rol.NombreRol);
				return Convert.ToInt32(dt.Rows[0]["roId"]);
			}
			catch (Exception ex)
			{throw ex;}
		}
		public int verificarRolExistente(string rolACrear) {
			try
			{
				DaoSP dao = new DaoSP();
				return dao.EnviarDatosSP("verificarRolExistente", rolACrear);
			}
			catch (Exception ex)
			{throw ex;}
		}
		//Permite la modificacion de un rol mediante un SP
		public int modificarRolSP(Rol rol)
		{
			try
			{
				DaoSP dao = new DaoSP();
				return dao.EnviarDatosSP("modificarRol",rol.RolId,rol.NombreRol);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Rol> obtenerRolesSP() {
			try
				{
					DaoSP daoSP = new DaoSP();
					return daoSP.ObtenerListadoSP<Rol>("getRoles");
				}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		public DataTable obtenerRolesDT()
		{
			try
			{
				DaoSP daoSP = new DaoSP();
				return daoSP.ObtenerDatosSP("getRoles");
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
		//Permite la modificacion de un rol mediante un Query
		public int modificarRol(Rol rol)
		{
			try
			{
				DaoObject dao = new DaoObject();
				Rol rols = new Rol();
				rols = dao.ObtenerUnObjeto<Rol>(rols.RolId);
				rols.Eliminado = false;
				rols.FechaEliminacion = DateTime.Now;
				return dao.Modificar(rols);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		//Permite la eliminacion (lógica) de un rol mediante un Query
		public int eliminarRolLog(int id)
		{
			try
			{
				DaoObject dao = new DaoObject();
				Rol rol = new Rol();
				rol = dao.ObtenerUnObjeto<Rol>(id);
				rol.Eliminado = true;
				rol.FechaEliminacion = DateTime.Now;
				return dao.Modificar(rol);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		//Permite la eliminacion (física) de un rol mediante un Query
		public int eliminarRolFis(int id,Rol rol)
		{
			try
			{
				DaoObject dao = new DaoObject();
				return dao.EliminadoFisico(id,rol);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public List<Rol> obtenerRoles() {
			try
			{ DaoObject daoObject = new DaoObject();
				return daoObject.ObtenerListadoDeObjetos<Rol>();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
