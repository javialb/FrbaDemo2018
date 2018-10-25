using Models.Base;
using Models.Comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.Servicio
{
    public class UsuarioService
    {
		public int alta(Usuario user) {
			try
			{
				user.password= HashHelpers.SHA256(user.password);
                user.eliminado = false;
                //DaoSP dao = new DaoSP();
                //return dao.EnviarDatosSP("UsuarioAlta", passSHA256, user.userName);
                DaoObject daoObject = new DaoObject();
                return daoObject.Guardar(user);
                
			}
			catch (Exception ex)
			{throw ex;}
		}
		public int edicion(Usuario user)
		{
			try
			{
				DaoObject dao = new DaoObject();
				Usuario usuario = new Usuario();
				usuario = dao.ObtenerUnObjeto<Usuario>(user.UsuarioId);
				usuario.userName = user.userName;
				return dao.Modificar(usuario);
		    }
			catch (Exception ex)
			{ throw ex; }
		}
		public DataTable obtenerUsuariosDt()
		{
			try
			{
				DaoSP daoSP = new DaoSP();
				return daoSP.ObtenerDatosSP("getUsuarios");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public int eliminadoLog(int id)
		{
			try
			{
				DaoObject dao = new DaoObject();
				Usuario usuario = new Usuario();
				usuario = dao.ObtenerUnObjeto<Usuario>(id);
				usuario.eliminado = true;
				usuario.fechaEliminacion = DateTime.Now;
				return dao.Modificar(usuario);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public Usuario getUsuarioById(int id) {
			try
			{
				DaoObject dao = new DaoObject();
				Usuario usuario = new Usuario();
				usuario = dao.ObtenerUnObjeto<Usuario>(id);
				return usuario;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
