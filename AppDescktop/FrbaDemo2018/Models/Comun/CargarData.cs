using Models.Base;
using Models.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Models.Comun
{
    public class CargarData
    {
		/// <summary>
		/// ////
		/// </summary>
		/// <param name="combo"></param>
		/// <param name="opciones"></param>

		public static void cargarComboBox(ComboBox combo, List<Object> opciones)
		{
			try
			{
				foreach (Object opcion in opciones)
				{
					combo.Items.Add(opcion);
				}
			}
			catch (Exception ex)
			{
					throw ex;
			}
			
		}
		public static void cargarGridView(DataGridView dataGrid, List<Rol>lista)
		{
			try
			{
				dataGrid.Columns.Clear();
				dataGrid.DataSource = null;
				dataGrid.DataSource = lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public static void cargarGridView(DataGridView dataGrid, DataTable tabla)
		{
			try
			{
				dataGrid.Columns.Clear();
				dataGrid.DataSource = null;
				dataGrid.DataSource = tabla;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public static void AddCheckColumn(DataGridView dataGrid)
		{
			//Asignar la propiedad DataSource
			DataGridViewCheckBoxColumn chkbox = new DataGridViewCheckBoxColumn();
			dataGrid.Columns.Add(chkbox);
			chkbox.HeaderText = "Check Data";
			chkbox.Name = "seleccion";
		}
		public static void AddButtonColumn(DataGridView dataGrid)
		{
			DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
			btnEditar.HeaderText = "Seleccionar";
			btnEditar.Name = "Editar";
			btnEditar.Text = "Editar";
			btnEditar.UseColumnTextForButtonValue = true;
			btnEditar.CellTemplate.Style.BackColor = Color.DarkGreen;
			dataGrid.Columns.Add(btnEditar);
			btnEditar.DisplayIndex = 0;
			//------------Agrego el boton para eliminar un rol --------
			DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
			btnEliminar.HeaderText = "Seleccionar";
			btnEliminar.Name = "Eliminar";
			btnEliminar.Text = "Eliminar";
			btnEliminar.UseColumnTextForButtonValue = true;
			btnEliminar.CellTemplate.Style.BackColor = Color.Red;
			dataGrid.Columns.Add(btnEliminar);
			btnEliminar.DisplayIndex = 1;
		}
	}
}
