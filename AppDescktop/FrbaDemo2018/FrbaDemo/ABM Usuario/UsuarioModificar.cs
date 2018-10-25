using Models;
using Models.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaDemo.ABM_Usuario
{
	public partial class UsuarioModificar : Form
	{
		public UsuarioModificar()
		{
			InitializeComponent();
		}
		public UsuarioModificar(int id)
		{
			try
			{
				Usuario usuario = new Usuario();
				UsuarioService service = new UsuarioService();
				usuario = service.obtenerUsuariosById(id);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK);
				throw;
			}
			InitializeComponent();
		}
		private void UsuarioModificar_Load(object sender, EventArgs e)
		{

		}
	}
}
