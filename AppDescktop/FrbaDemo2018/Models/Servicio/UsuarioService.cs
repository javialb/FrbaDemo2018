using Models.Base;
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

				DaoSP dao = new DaoSP();
				return dao.EnviarDatosSP("UsuarioAlta",user.password,user.nombre,user.apellido,user.tipoDocumentoId,
					user.numDocu,user.Mail,user.Telefono,user.Fecha_nacimiento_struct);
			}
			catch (Exception ex)
			{throw ex;}
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
		public int eliminarUsuarioLog(int id)
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
	}
}
