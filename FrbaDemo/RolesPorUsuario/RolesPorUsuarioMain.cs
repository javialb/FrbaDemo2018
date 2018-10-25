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

namespace FrbaDemo.RolesPorUsuario
{
	public partial class RolesPorUsuarioMain : Form
	{
		public RolesPorUsuarioMain()
		{
			InitializeComponent();
		}

		private void RolesPorUsuarioMain_Load(object sender, EventArgs e)
		{
			RolService rolService = new RolService();
			CargarData.cargarGridView(dgvRoles, rolService.obtenerRoles());
			CargarData.AddCheckColumn(dgvRoles);
		}

	}
}
