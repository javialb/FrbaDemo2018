using Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Servicio
{
    public class UsuarioService
    {
		public int alta(Usuario user) {
			try
			{
				DaoSP dao = new DaoSP();
				return dao.EnviarDatosSP("");
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
    }
}
