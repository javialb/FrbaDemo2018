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
	public partial class FuncionalidadAlta : Form
	{
		public FuncionalidadAlta()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (todosCamposCompletos())
				{
					//Crear una Funcionalidad
					Funcionalidad funcionalidad = new Funcionalidad();
					funcionalidad.FuncionalidadDescripcion = txtDescripcion.Text;
					funcionalidad.Habilitado = true;
					//Transaccion
					FuncionalidadService service = new FuncionalidadService();
					int respuesta = service.agregarFuncionalidad(funcionalidad);
					if (respuesta == 0)
					{
						MessageBox.Show("Error con la DB. No se ha completado la solicitud.", "Error al crear intentar crear",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					MessageBox.Show("Funcionalidad " + txtDescripcion.Text + " creada satisfactoriamente.", "Alta de Funcionalidad",
					MessageBoxButtons.OK);
					new FuncionalidadMain().Show();
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
				MensajesToolTip.showToolTip("Ingrese una descripcion para crear la funcionalidad.", txtDescripcion, txtDescripcion.Location);
				return false;
			}
			return true;
		}
	}
}
