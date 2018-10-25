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
	public partial class RolMain : Form
	{
		public RolMain()
		{
			InitializeComponent();
		}

		private void RolMain_Load(object sender, EventArgs e)
		{
			try
			{
				cargarGrillaRoles();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void cargarGrillaRoles() {
			try
			{
				RolService servicio = new RolService();
				CargarData.cargarGridView(dgvRol, servicio.obtenerRolesDT());
				CargarData.AddButtonColumn(dgvRol);
				this.dgvRol.CellContentClick += new DataGridViewCellEventHandler(this.DgvRol_CellContentClick_1);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public void updateGrid()
		{
			//buttonBuscar_Click(null, null);
		}
		private void DgvRol_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string nombreRol = dgvRol.CurrentRow.Cells["nombreRol"].Value.ToString();
				//modificando
				if (this.dgvRol.Columns[e.ColumnIndex].Name.Equals("Editar"))
				{
					DialogResult dr = MessageBox.Show("¿Desea modificar datos del Rol:  " + nombreRol + "?", "Modificar", MessageBoxButtons.YesNo);
					switch (dr)
					{
						case DialogResult.Yes:
							//Nuevo Form que recibe el nombre del rol a Modificar
							Modificar(dgvRol.CurrentRow.Cells["rolId"].Value.ToString(), nombreRol);
							
							break;
						case DialogResult.No: break;
					}
				}
				//Eliminando
				if (this.dgvRol.Columns[e.ColumnIndex].Name.Equals("Eliminar")) {
					DialogResult dr = MessageBox.Show("¿Realmente Desea eliminar el Rol:  " + nombreRol + "?", "Eliminar", MessageBoxButtons.YesNo);
					switch (dr)
					{
						case DialogResult.Yes:
							//Nuevo Form que recibe el nombre del rol a Modificar
							//Modificar Rol
							RolService rolservice = new RolService();
							if (rolservice.eliminarRolLog(int.Parse(dgvRol.CurrentRow.Cells["rolId"].Value.ToString())) == 0)
							{
								MessageBox.Show("Error al conectarse con la DB. No se ha eliminado el Rol.", "Error al intentar eliminar un Rol",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
							MessageBox.Show("El Rol seleccionado fue eliminado satisfactoriamente.", "Eliminacion del Rol",
							MessageBoxButtons.OK);
							cargarGrillaRoles();
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
		private void Modificar(string idRol,string rolElegido)
		{
			//new RolModificar(idRol,rolElegido).Show();
			new RolPorFuncionalidadesModificar(idRol, rolElegido).Show();
			this.Hide();
			//helpers.deshabilitarAnterior(this);
		}
		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			//Limpiamos la DataGrid
			cleanGrid();
			//Limpiamos lo demas?
			textRol.Text = "";
			//comboFuncionalidad.SelectedItem = null;
			//comboEstado.SelectedItem = null;
		}
		public void cleanGrid()
		{
			dgvRol.DataSource = null;
			dgvRol.Update();
		}

		private void btnAlta_Click(object sender, EventArgs e)
		{
			new RolPorFuncionalidades().Show();
			Helpers.deshabilitarAnterior(this);

		}
	}
}
