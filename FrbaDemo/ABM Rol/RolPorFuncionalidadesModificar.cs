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
	public partial class RolPorFuncionalidadesModificar : Form
	{
		public RolPorFuncionalidadesModificar()
		{
			InitializeComponent();
		}
		public RolPorFuncionalidadesModificar(string id, string nombreRol) {
			InitializeComponent();
			txtCodigo.Text = id;
			txtCodigo.ReadOnly = true;
			txtNombreRol.Text = nombreRol;
		}
		private void RolPorFuncionalidadesModificar_Load(object sender, EventArgs e)
		{
			FuncionalidadService funcionalidadService = new FuncionalidadService();
			CargarData.cargarGridView(dgvFuncionalidades, funcionalidadService.obtenerFuncionalidadesDT());
			CargarData.AddCheckColumn(dgvFuncionalidades);
			BuscarFuncionalidadesPorRol(int.Parse(txtCodigo.Text));
		}
		private void BuscarFuncionalidadesPorRol(int rolId)
		{
			List<int> ChkedRow = new List<int>();
			FuncionalidadesPorRolService funcPorRols = new FuncionalidadesPorRolService();
			Rol r = new Rol();

			int i = 0;
			try
			{
				List<Funcionalidad> f = new List<Funcionalidad>();
				List<int> idsFuncionalidades = new List<int>();
				idsFuncionalidades = funcPorRols.getFuncionalidadesPorRol(rolId);
				for (i = 1; i <= dgvFuncionalidades.RowCount; i++)
				{
					if (idsFuncionalidades.Contains(i))
					{
						//lo voy seleccionando al q cumpla
						dgvFuncionalidades.Rows[i - 1].Cells["seleccion"].Value = true;
					}


				}



			}
			catch (Exception e) { }

		}
		public void cargarFuncionalidadesPorRol(int rolId) {

			//CargarData.cargarGridView(dgvFuncionalidades,);
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			try
			{

			}
			catch (Exception)
			{

				throw;
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			new RolMain().Show();
			this.Hide();
		}
	}
}
