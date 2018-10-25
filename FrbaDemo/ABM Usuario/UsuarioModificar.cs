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
	public partial class UsuarioModificar : Form
	{
		public UsuarioModificar()
		{
			InitializeComponent();
		}
		public UsuarioModificar(int id)
		{
			InitializeComponent();
			UsuarioService usuarioService = new UsuarioService();
			Usuario usuario = new Usuario();
			usuario = usuarioService.getUsuarioById(id);
			txtHiden.Text = usuario.UsuarioId.ToString();
			txtNombre.Text = usuario.userName;
			
		}
		private void UsuarioModificar_Load(object sender, EventArgs e)
		{

		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (todosCamposCompletos())
				{
					Usuario usuario = new Usuario();
					usuario.userName = txtNombre.Text;
					usuario.UsuarioId = int.Parse(txtHiden.Text);
					UsuarioService service = new UsuarioService();
					int resp = service.edicion(usuario);
					if (resp == 0)
					{
						MessageBox.Show("Error al conectarse con la BD. No se ha podido editar el Usuario.", "Error al editar el Usuario",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					MessageBox.Show("Usuario " + txtNombre.Text + " editado satisfactoriamente.", "Edición de Usuario",
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
				MensajesToolTip.showToolTip("Ingrese un nombre de usuario.", txtNombre, txtNombre.Location);
				return false;
			}
			return true;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			UsuarioMain usuarioMain = new UsuarioMain();
			this.Close();
			usuarioMain.Show();
		}
	}
}
