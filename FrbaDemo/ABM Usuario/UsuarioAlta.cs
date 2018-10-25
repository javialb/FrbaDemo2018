using Models;
using Models.Comun;
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
	public partial class UsuarioAlta : Form
	{
		public UsuarioAlta()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (todosCamposCompletos())
				{
					Usuario usuario = new Usuario();
					usuario.password = txtContraseña.Text;
                    usuario.userName = txtNombre.Text;
					UsuarioService service = new UsuarioService();
					int resp = service.alta(usuario);
					if (resp == 0)
					{
						MessageBox.Show("Error al conectarse con la DB. No se ha creado el Usuario.", "Error al crear Nuevo Usuario",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					MessageBox.Show("Usuario " + txtNombre.Text + " creado satisfactoriamente.", "Alta de Usuario",
					MessageBoxButtons.OK);
					new UsuarioMain().Show();
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private bool todosCamposCompletos()
		{
			if (txtNombre.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese un nombre.", txtNombre, txtNombre.Location);
				return false;
			}
			if (txtContraseña.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese una contraseña.", txtContraseña, txtContraseña.Location);
				return false;
			}
			return true;
		}

		private void UsuarioAlta_Load(object sender, EventArgs e)
		{
			//TipoDocumentoSerevice service = new TipoDocumentoSerevice();
			//CargarData.cargarComboBox(cbxTipoDocumento, service.obtenerTiposDocumentosDt(),
			//	"id","descripcion");
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			UsuarioMain usuarioMain = new UsuarioMain();
			this.Close();
			usuarioMain.Show();
		}
	}
}
