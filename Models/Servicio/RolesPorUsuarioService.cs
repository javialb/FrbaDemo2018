using Models.Base;
using Models.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Servicio
{
    class RolesPorUsuarioService
    {

		//Se realiza el alta de una nueva funcionalidad mediante un objeto
		public int agregarRolesPorUsuario(Usuario usuario)
		{
			try
			{
				DaoObject dao = new DaoObject();
				return dao.Guardar(usuario);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
	}
}
