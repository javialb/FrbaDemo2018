using Models.Base;
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
	public partial class UsuarioMain : Form
	{
		public UsuarioMain()
		{
			InitializeComponent();
		}

		private void UsuarioMain_Load(object sender, EventArgs e)
		{
			try
			{
				cargarGrillaUsuarios();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void cargarGrillaUsuarios()
		{
			try
			{
				UsuarioService servicio = new UsuarioService();
				CargarData.cargarGridView(dgvUsuarios, servicio.obtenerUsuariosDt());
				CargarData.AddButtonColumn(dgvUsuarios);
				this.dgvUsuarios.CellContentClick += new DataGridViewCellEventHandler(this.DgvUsuario_CellContentClick_1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void DgvUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string nombre = dgvUsuarios.CurrentRow.Cells["userName"].Value.ToString();
				//modificando
				if (this.dgvUsuarios.Columns[e.ColumnIndex].Name.Equals("Editar"))
				{
					DialogResult dr = MessageBox.Show("¿Desea modificar datos del usuario:  " + nombre + "?", "Modificar", MessageBoxButtons.YesNo);
					switch (dr)
					{
						case DialogResult.Yes:
							//Nuevo Form que recibe el nombre del rol a Modificar
							Modificar(dgvUsuarios.CurrentRow.Cells["usuarioId"].Value.ToString());

							break;
						case DialogResult.No: break;
					}
				}
				//Eliminando
				if (this.dgvUsuarios.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
				{
					DialogResult dr = MessageBox.Show("¿Realmente Desea eliminar el usuario:  " + nombre + "?", "Eliminar", MessageBoxButtons.YesNo);
					switch (dr)
					{
						case DialogResult.Yes:
							//Nuevo Form que recibe el id del usuario a Modificar
							//Eliminar Usuario
							UsuarioService usuarioService = new UsuarioService();
							if (usuarioService.eliminadoLog(int.Parse(dgvUsuarios.CurrentRow.Cells["usuarioId"].Value.ToString())) == 0)
							{
								MessageBox.Show("Error al conectarse con la DB. No se ha eliminado el Usuario.", "Error al intentar eliminar",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
							MessageBox.Show("El Usuario seleccionado fue eliminado satisfactoriamente.", "Eliminacion de usuario",
							MessageBoxButtons.OK);
							cargarGrillaUsuarios();
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
		private void Modificar(string id)
		{
			//new RolModificar(idRol,rolElegido).Show();
			new UsuarioModificar(int.Parse(id)).Show();
			this.Hide();
			//helpers.deshabilitarAnterior(this);
		}
		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			//Limpiamos la DataGrid
			cleanGrid();
			//Limpiamos lo demas?
			//textRol.Text = "";
		}
		public void cleanGrid()
		{
			dgvUsuarios.DataSource = null;
			dgvUsuarios.Update();
		}

		private void btnAlta_Click(object sender, EventArgs e)
		{
			new UsuarioAlta().Show();
			Helpers.deshabilitarAnterior(this);
		}
	}
}
