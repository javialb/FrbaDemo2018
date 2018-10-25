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

namespace FrbaDemo.ABM_Funcionalidad
{
	public partial class FuncionalidadMain : Form
	{
		public FuncionalidadMain()
		{
			InitializeComponent();
		}

		private void FuncionalidadMain_Load(object sender, EventArgs e)
		{
			try
			{
				cargarGrillaFuncionalidades();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void cargarGrillaFuncionalidades()
		{
			try
			{
				FuncionalidadService servicio = new FuncionalidadService();
				CargarData.cargarGridView(dgvFuncionalidad, servicio.obtenerFuncionalidadesDT());
				CargarData.AddButtonColumn(dgvFuncionalidad);
				this.dgvFuncionalidad.CellContentClick += new DataGridViewCellEventHandler(this.DgvFuncionalidad_CellContentClick_1);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DgvFuncionalidad_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string Descripcion = dgvFuncionalidad.CurrentRow.Cells["FuncionalidadDescripcion"].Value.ToString();
				//Modificando
				if (this.dgvFuncionalidad.Columns[e.ColumnIndex].Name.Equals("Editar"))
				{
					DialogResult dr = MessageBox.Show("¿Desea modificar:  " + Descripcion + "?", "Modificar", MessageBoxButtons.YesNo);
					switch (dr)
					{
						case DialogResult.Yes:
							//Nuevo Form que recibe el nombre del rol a Modificar
							Modificar(dgvFuncionalidad.CurrentRow.Cells["FuncionalidadId"].Value.ToString(), Descripcion);

							break;
						case DialogResult.No: break;
					}
				}
				//Eliminando
				if (this.dgvFuncionalidad.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
				{
					DialogResult dr = MessageBox.Show("¿Realmente Desea eliminar " + Descripcion + "?", "Eliminar", MessageBoxButtons.YesNo);
					switch (dr)
					{
						case DialogResult.Yes:
							FuncionalidadService funcService = new FuncionalidadService();
							if (funcService.eliminarFuncionalidadLog(int.Parse(dgvFuncionalidad.CurrentRow.Cells["FuncionalidadId"].Value.ToString())) == 0)
							{
								MessageBox.Show("Error con la DB. No se ha completado la solicitud.", "Error al intentar eliminar",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
							MessageBox.Show("Solicitud completada satisfactoriamente.", "Eliminacion completada",
							MessageBoxButtons.OK);
							cargarGrillaFuncionalidades();
							break;
						case DialogResult.No: break;
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void Modificar(string id, string descripcion)
		{
			this.Hide();
			new FuncionalidadModificar(id,descripcion).Show();
			//helpers.deshabilitarAnterior(this);
		}
		public void cleanGrid()
		{
			dgvFuncionalidad.DataSource = null;
			dgvFuncionalidad.Update();
		}
		private void btnAlta_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			new FuncionalidadAlta().Show();
			//Helpers.deshabilitarAnterior(this);
		}

		private void buttonLimpiar_Click_1(object sender, EventArgs e)
		{//Limpiamos la DataGrid
			cleanGrid();
			//Limpiamos lo demas?
			textRol.Text = "";
			//comboFuncionalidad.SelectedItem = null;
			comboEstado.SelectedItem = null;

		}
	}
}
