using Models.Base;
using Models.Comun;
using Models.Dominio;
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

namespace FrbaDemo.ABM_Rol
{
	public partial class RolModificar : Form
	{
		public RolModificar()
		{
			InitializeComponent();
		}
		public RolModificar(string id,string nombreRol)
		{
			InitializeComponent();
			txtCodigo.Text = id;
			txtCodigo.ReadOnly = true;
			txtNombreRol.Text = nombreRol;
		}
		private void RolModificar_Load(object sender, EventArgs e)
		{

		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			try
			{
				if (todosCamposCompletos())
				{
					//Modificar Rol
					Rol rol = new Rol();
					rol.RolId = int.Parse(txtCodigo.Text);
					rol.NombreRol = txtNombreRol.Text;
					rol.Habilitado = true;
					//Transaccion
					RolService service = new RolService();
					int respuesta = service.modificarRol(rol);
					if (respuesta == 0)
					{
						MessageBox.Show("Error al intentar modificar el Rol.", "Error al modificar el Rol",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					MessageBox.Show("El Rol: " + txtNombreRol.Text + ", fue modificado satisfactoriamente.", "Modificacion de Rol",
					MessageBoxButtons.OK);
					new RolMain().Show();
					//helpers.deshabilitarAnterior(this);
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK);
			}

		}
		private bool todosCamposCompletos()
		{
			if (txtNombreRol.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese un nombre para modificar el rol.", txtNombreRol, txtNombreRol.Location);
				return false;
			}
			return true;
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);

			if (e.CloseReason == CloseReason.WindowsShutDown) return;

			// Confirm user wants to close
			Global.habilitarAnterior();
		}
	}
}
