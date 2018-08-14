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
					usuario.nombre = txtNombre.Text;
					usuario.apellido = txtApellido.Text;
					usuario.Mail = txtMail.Text;
					usuario.tipoDocumentoId = 1;
					usuario.Fecha_nacimiento_struct = dtpFechaNacimiento.Value;
					usuario.numDocu = int.Parse(txtNroDoc.Text);
					UsuarioService service = new UsuarioService();
					int resp = service.alta(usuario);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		private bool todosCamposCompletos()
		{
			if (txtNombre.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese un nombre.", txtNombre, txtNombre.Location);
				return false;
			}
			if (txtApellido.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese un apellido.", txtApellido, txtApellido.Location);
				return false;
			}
			if (txtMail.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese un mail.", txtMail, txtMail.Location);
				return false;
			}
			if (dtpFechaNacimiento.Text.Trim() == "" || dtpFechaNacimiento.Value==null)
			{
				MensajesToolTip.showToolTip("Ingrese una fecha de nacimiento.", dtpFechaNacimiento, dtpFechaNacimiento.Location);
				return false;
			}
			return true;
		}
	}
}
