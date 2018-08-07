namespace FrbaDemo.ABM_Funcionalidad
{
	partial class FuncionalidadMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Button btnAlta;
			this.titulo = new System.Windows.Forms.Label();
			this.dgvFuncionalidad = new System.Windows.Forms.DataGridView();
			this.groupFiltros = new System.Windows.Forms.GroupBox();
			this.comboEstado = new System.Windows.Forms.ComboBox();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.lblEstado = new System.Windows.Forms.Label();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.lblRol = new System.Windows.Forms.Label();
			this.textRol = new System.Windows.Forms.TextBox();
			btnAlta = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidad)).BeginInit();
			this.groupFiltros.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAlta
			// 
			btnAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
			btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
			btnAlta.Location = new System.Drawing.Point(14, 79);
			btnAlta.Margin = new System.Windows.Forms.Padding(5);
			btnAlta.Name = "btnAlta";
			btnAlta.Size = new System.Drawing.Size(201, 41);
			btnAlta.TabIndex = 15;
			btnAlta.Text = "Nueva funcionalidad";
			btnAlta.UseVisualStyleBackColor = false;
			btnAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
			// 
			// titulo
			// 
			this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(198, 16);
			this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(385, 58);
			this.titulo.TabIndex = 8;
			this.titulo.Text = "Listado de Funcionaliadades";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvFuncionalidad
			// 
			this.dgvFuncionalidad.AllowUserToAddRows = false;
			this.dgvFuncionalidad.AllowUserToDeleteRows = false;
			this.dgvFuncionalidad.AllowUserToResizeColumns = false;
			this.dgvFuncionalidad.AllowUserToResizeRows = false;
			this.dgvFuncionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvFuncionalidad.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.dgvFuncionalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionalidad.Location = new System.Drawing.Point(14, 327);
			this.dgvFuncionalidad.Margin = new System.Windows.Forms.Padding(5);
			this.dgvFuncionalidad.MultiSelect = false;
			this.dgvFuncionalidad.Name = "dgvFuncionalidad";
			this.dgvFuncionalidad.ReadOnly = true;
			this.dgvFuncionalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvFuncionalidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFuncionalidad.Size = new System.Drawing.Size(770, 204);
			this.dgvFuncionalidad.TabIndex = 14;
			// 
			// groupFiltros
			// 
			this.groupFiltros.Controls.Add(this.comboEstado);
			this.groupFiltros.Controls.Add(this.buttonLimpiar);
			this.groupFiltros.Controls.Add(this.lblEstado);
			this.groupFiltros.Controls.Add(this.buttonBuscar);
			this.groupFiltros.Controls.Add(this.lblRol);
			this.groupFiltros.Controls.Add(this.textRol);
			this.groupFiltros.Location = new System.Drawing.Point(14, 136);
			this.groupFiltros.Margin = new System.Windows.Forms.Padding(5);
			this.groupFiltros.Name = "groupFiltros";
			this.groupFiltros.Padding = new System.Windows.Forms.Padding(5);
			this.groupFiltros.Size = new System.Drawing.Size(770, 166);
			this.groupFiltros.TabIndex = 13;
			this.groupFiltros.TabStop = false;
			this.groupFiltros.Text = "Filtros de busqueda";
			// 
			// comboEstado
			// 
			this.comboEstado.FormattingEnabled = true;
			this.comboEstado.Location = new System.Drawing.Point(216, 107);
			this.comboEstado.Margin = new System.Windows.Forms.Padding(5);
			this.comboEstado.Name = "comboEstado";
			this.comboEstado.Size = new System.Drawing.Size(198, 24);
			this.comboEstado.TabIndex = 5;
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.Location = new System.Drawing.Point(514, 98);
			this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(5);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(201, 41);
			this.buttonLimpiar.TabIndex = 11;
			this.buttonLimpiar.Text = "Limpiar";
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click_1);
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(25, 118);
			this.lblEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(52, 17);
			this.lblEstado.TabIndex = 4;
			this.lblEstado.Text = "Estado";
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.Location = new System.Drawing.Point(514, 29);
			this.buttonBuscar.Margin = new System.Windows.Forms.Padding(5);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(201, 41);
			this.buttonBuscar.TabIndex = 10;
			this.buttonBuscar.Text = "Buscar";
			this.buttonBuscar.UseVisualStyleBackColor = true;
			// 
			// lblRol
			// 
			this.lblRol.AutoSize = true;
			this.lblRol.Location = new System.Drawing.Point(25, 60);
			this.lblRol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(181, 17);
			this.lblRol.TabIndex = 1;
			this.lblRol.Text = "Nombre de la funcionalidad";
			// 
			// textRol
			// 
			this.textRol.Location = new System.Drawing.Point(216, 55);
			this.textRol.Margin = new System.Windows.Forms.Padding(5);
			this.textRol.Name = "textRol";
			this.textRol.Size = new System.Drawing.Size(198, 22);
			this.textRol.TabIndex = 0;
			// 
			// FuncionalidadMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 541);
			this.Controls.Add(btnAlta);
			this.Controls.Add(this.dgvFuncionalidad);
			this.Controls.Add(this.groupFiltros);
			this.Controls.Add(this.titulo);
			this.Name = "FuncionalidadMain";
			this.Text = "Panel principal para la gestion de funcionaliadades";
			this.Load += new System.EventHandler(this.FuncionalidadMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidad)).EndInit();
			this.groupFiltros.ResumeLayout(false);
			this.groupFiltros.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titulo;
		private System.Windows.Forms.DataGridView dgvFuncionalidad;
		private System.Windows.Forms.GroupBox groupFiltros;
		private System.Windows.Forms.ComboBox comboEstado;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.TextBox textRol;
	}
}