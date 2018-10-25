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
	public partial class RolPorFuncionalidades : Form
	{
		public RolPorFuncionalidades()
		{
			InitializeComponent();
		}

		private void RolPorFuncionalidades_Load(object sender, EventArgs e)
		{
			FuncionalidadService funcionalidadService = new FuncionalidadService();
			CargarData.cargarGridView(dgvFuncionalidades,funcionalidadService.obtenerFuncionalidadesDT());
			CargarData.AddCheckColumn(dgvFuncionalidades);
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				if (todosCamposCompletos())
				{
					//Transaccion
					RolService service = new RolService();
					//Verificacion si el rol a crear ya existe
					if (service.verificarRolExistente(txtNombreRol.Text) > 0)
					{
						MessageBox.Show("Error. Nombre del rol ya existente");
					}
					else
					{
						//Crear Rol
						Rol rol = new Rol();
						rol.NombreRol = txtNombreRol.Text;
						rol.Habilitado = true;
						int respuesta = service.agregarRolSP(rol);
						if (respuesta == 0)
						{
							MessageBox.Show("Error al conectarse con la DB. No se ha creado el Rol.", "Error al crear Nuevo Rol",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
						int resultado = agregarFuncionalidades(respuesta);
						MessageBox.Show("Rol " + txtNombreRol.Text + " creado satisfactoriamente.", "Alta Rol",
						MessageBoxButtons.OK);
						new RolMain().Show();
						this.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error en el alta de rol -" + ex.Message);
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
		private int agregarFuncionalidades(int idRol)
		{
			int respFunc=0;
			List<int> ChkedRow = new List<int>();
			try
			{
				int i = 0;
				for (i = 0; i <= dgvFuncionalidades.RowCount - 1; i++)
				{
					if (Convert.ToBoolean(dgvFuncionalidades.Rows[i].Cells["seleccion"].Value) == true)
					{
						ChkedRow.Add(i);
					}
				}
				if (ChkedRow.Count == 0) { return 0; }
				foreach (int k in ChkedRow)
				{
					FuncionalidadPorRol funcionalidadPorRol = new FuncionalidadPorRol();
					FuncionalidadesPorRolService fn = new FuncionalidadesPorRolService();
					funcionalidadPorRol.rolId = idRol;
					funcionalidadPorRol.funcionalidadId = Int32.Parse(dgvFuncionalidades.Rows[k].Cells[0].Value.ToString());
					funcionalidadPorRol.habilitado = true;
					respFunc=fn.agregarFuncionalidadPorRol(funcionalidadPorRol);
				}
				//MessageBox.Show("Rol y funcionalidades registrados Correctamente!");
				//Alta_Rol_Funcionalidad af = new Alta_Rol_Funcionalidad();
				//af.Close();
				return respFunc;
			}
			catch (Exception e) { return 0; }
		}

	}
}
