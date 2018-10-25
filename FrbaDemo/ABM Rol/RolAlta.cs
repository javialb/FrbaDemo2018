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
	public partial class RolAlta : Form
	{
		public RolAlta()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (todosCamposCompletos())
				{
					//Crear Rol
					Rol rol = new Rol();
					rol.NombreRol = txtNombreRol.Text;
					rol.Habilitado = true;
					//Funcionalidad funcionalidad_elegida = funcionalidades[comboFuncionalidades.SelectedIndex];
					//Transaccion
					RolService service = new RolService();
					int respuesta = service.agregarRolSP(rol);
					if (respuesta==0)
					{
						MessageBox.Show("Error al conectarse con la DB. No se ha creado el Rol.", "Error al crear Nuevo Rol",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					MessageBox.Show("Rol " + txtNombreRol.Text + " creado satisfactoriamente.", "Alta Rol",
					MessageBoxButtons.OK);
					new RolMain().Show();
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ERROR",MessageBoxButtons.OK);
			}
		}
		private bool todosCamposCompletos()
		{
			if (txtNombreRol.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese un nombre para crear el rol.", txtNombreRol, txtNombreRol.Location);
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

		private void txtNombreRol_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblRol_Click(object sender, EventArgs e)
		{

		}

		private void RolAlta_Load(object sender, EventArgs e)
		{

		}
	}
}
