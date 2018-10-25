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

namespace FrbaDemo.ABM_Funcionalidad
{
	public partial class FuncionalidadModificar : Form
	{
		public FuncionalidadModificar()
		{
			InitializeComponent();
		}
		public FuncionalidadModificar(string id, string descripcion)
		{
			InitializeComponent();
			txtCodigo.Text = id;
			txtCodigo.ReadOnly = true;
			txtDescripcion.Text = descripcion;
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			try
			{
				if (todosCamposCompletos())
				{
					//Modificar Rol
					Funcionalidad funcionalidad = new Funcionalidad();
					funcionalidad.FuncionalidadId = int.Parse(txtCodigo.Text);
					funcionalidad.FuncionalidadDescripcion = txtDescripcion.Text;
					funcionalidad.Habilitado = true;
					//Transaccion
					FuncionalidadService service = new FuncionalidadService();
					int respuesta = service.modificarFuncionalidad(funcionalidad);
					if (respuesta == 0)
					{
						MessageBox.Show("Error al intentar modificar la funcionalidad.", "Error al modificar",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					MessageBox.Show("El Funcionalidad: " + txtDescripcion.Text + ", modificada satisfactoriamente.", "Modificacion de Funcionalidad",
					MessageBoxButtons.OK);
					new FuncionalidadMain().Show();
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
			if (txtDescripcion.Text.Trim() == "")
			{
				MensajesToolTip.showToolTip("Ingrese una descripcion a modificar.", txtDescripcion, txtDescripcion.Location);
				return false;
			}
			return true;
		}
	}
}
