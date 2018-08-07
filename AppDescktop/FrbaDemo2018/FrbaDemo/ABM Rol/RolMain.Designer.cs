namespace FrbaDemo.ABM_Rol
{
	partial class RolMain
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
			this.groupFiltros = new System.Windows.Forms.GroupBox();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.lblRol = new System.Windows.Forms.Label();
			this.textRol = new System.Windows.Forms.TextBox();
			this.dgvRol = new System.Windows.Forms.DataGridView();
			this.cbxFuncionalidad = new System.Windows.Forms.ComboBox();
			this.lblFuncionalidad = new System.Windows.Forms.Label();
			btnAlta = new System.Windows.Forms.Button();
			this.groupFiltros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRol)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAlta
			// 
			btnAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
			btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
			btnAlta.Location = new System.Drawing.Point(14, 56);
			btnAlta.Margin = new System.Windows.Forms.Padding(5);
			btnAlta.Name = "btnAlta";
			btnAlta.Size = new System.Drawing.Size(201, 41);
			btnAlta.TabIndex = 12;
			btnAlta.Text = "Nuevo rol";
			btnAlta.UseVisualStyleBackColor = false;
			btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
			// 
			// titulo
			// 
			this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(274, 12);
			this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(211, 37);
			this.titulo.TabIndex = 7;
			this.titulo.Text = "Listado de Roles";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupFiltros
			// 
			this.groupFiltros.Controls.Add(this.cbxFuncionalidad);
			this.groupFiltros.Controls.Add(this.lblFuncionalidad);
			this.groupFiltros.Controls.Add(this.buttonLimpiar);
			this.groupFiltros.Controls.Add(this.buttonBuscar);
			this.groupFiltros.Controls.Add(this.lblRol);
			this.groupFiltros.Controls.Add(this.textRol);
			this.groupFiltros.Location = new System.Drawing.Point(14, 113);
			this.groupFiltros.Margin = new System.Windows.Forms.Padding(5);
			this.groupFiltros.Name = "groupFiltros";
			this.groupFiltros.Padding = new System.Windows.Forms.Padding(5);
			this.groupFiltros.Size = new System.Drawing.Size(770, 166);
			this.groupFiltros.TabIndex = 8;
			this.groupFiltros.TabStop = false;
			this.groupFiltros.Text = "Filtros de busqueda";
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
			this.lblRol.Location = new System.Drawing.Point(25, 37);
			this.lblRol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(121, 20);
			this.lblRol.TabIndex = 1;
			this.lblRol.Text = "Nombre de Rol";
			// 
			// textRol
			// 
			this.textRol.Location = new System.Drawing.Point(181, 32);
			this.textRol.Margin = new System.Windows.Forms.Padding(5);
			this.textRol.Name = "textRol";
			this.textRol.Size = new System.Drawing.Size(198, 26);
			this.textRol.TabIndex = 0;
			// 
			// dgvRol
			// 
			this.dgvRol.AllowUserToAddRows = false;
			this.dgvRol.AllowUserToDeleteRows = false;
			this.dgvRol.AllowUserToResizeColumns = false;
			this.dgvRol.AllowUserToResizeRows = false;
			this.dgvRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRol.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.dgvRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRol.Location = new System.Drawing.Point(14, 304);
			this.dgvRol.Margin = new System.Windows.Forms.Padding(5);
			this.dgvRol.MultiSelect = false;
			this.dgvRol.Name = "dgvRol";
			this.dgvRol.ReadOnly = true;
			this.dgvRol.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRol.Size = new System.Drawing.Size(770, 204);
			this.dgvRol.TabIndex = 9;
			// 
			// cbxFuncionalidad
			// 
			this.cbxFuncionalidad.FormattingEnabled = true;
			this.cbxFuncionalidad.Location = new System.Drawing.Point(179, 71);
			this.cbxFuncionalidad.Margin = new System.Windows.Forms.Padding(4);
			this.cbxFuncionalidad.Name = "cbxFuncionalidad";
			this.cbxFuncionalidad.Size = new System.Drawing.Size(200, 28);
			this.cbxFuncionalidad.TabIndex = 13;
			// 
			// lblFuncionalidad
			// 
			this.lblFuncionalidad.AutoSize = true;
			this.lblFuncionalidad.Location = new System.Drawing.Point(34, 79);
			this.lblFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFuncionalidad.Name = "lblFuncionalidad";
			this.lblFuncionalidad.Size = new System.Drawing.Size(112, 20);
			this.lblFuncionalidad.TabIndex = 12;
			this.lblFuncionalidad.Text = "Funcionalidad";
			// 
			// RolMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 535);
			this.Controls.Add(btnAlta);
			this.Controls.Add(this.dgvRol);
			this.Controls.Add(this.groupFiltros);
			this.Controls.Add(this.titulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RolMain";
			this.Text = "Panel principal para la gestion de roles";
			this.Load += new System.EventHandler(this.RolMain_Load);
			this.groupFiltros.ResumeLayout(false);
			this.groupFiltros.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRol)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titulo;
		private System.Windows.Forms.GroupBox groupFiltros;
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.TextBox textRol;
		private System.Windows.Forms.DataGridView dgvRol;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.ComboBox cbxFuncionalidad;
		private System.Windows.Forms.Label lblFuncionalidad;
	}
}