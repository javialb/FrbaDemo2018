namespace FrbaDemo.ABM_Rol
{
	partial class RolPorFuncionalidadesModificar
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
			this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
			this.lblLstFunc = new System.Windows.Forms.Label();
			this.txtNombreRol = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.btnVolver = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvFuncionalidades
			// 
			this.dgvFuncionalidades.AllowUserToAddRows = false;
			this.dgvFuncionalidades.AllowUserToDeleteRows = false;
			this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionalidades.Location = new System.Drawing.Point(83, 226);
			this.dgvFuncionalidades.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvFuncionalidades.Name = "dgvFuncionalidades";
			this.dgvFuncionalidades.Size = new System.Drawing.Size(609, 174);
			this.dgvFuncionalidades.TabIndex = 6;
			// 
			// lblLstFunc
			// 
			this.lblLstFunc.AutoSize = true;
			this.lblLstFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblLstFunc.Location = new System.Drawing.Point(79, 183);
			this.lblLstFunc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblLstFunc.Name = "lblLstFunc";
			this.lblLstFunc.Size = new System.Drawing.Size(241, 24);
			this.lblLstFunc.TabIndex = 7;
			this.lblLstFunc.Text = "Listado de Funcionalidades";
			// 
			// txtNombreRol
			// 
			this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNombreRol.Location = new System.Drawing.Point(255, 137);
			this.txtNombreRol.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtNombreRol.Name = "txtNombreRol";
			this.txtNombreRol.Size = new System.Drawing.Size(319, 28);
			this.txtNombreRol.TabIndex = 11;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblNombre.Location = new System.Drawing.Point(82, 141);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(163, 24);
			this.lblNombre.TabIndex = 10;
			this.lblNombre.Text = "Descripcion de rol";
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.btnActualizar.Location = new System.Drawing.Point(584, 84);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(136, 43);
			this.btnActualizar.TabIndex = 12;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtCodigo.Location = new System.Drawing.Point(255, 97);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(226, 30);
			this.txtCodigo.TabIndex = 16;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCodigo.Location = new System.Drawing.Point(100, 97);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(75, 25);
			this.lblCodigo.TabIndex = 15;
			this.lblCodigo.Text = "Codigo";
			// 
			// btnVolver
			// 
			this.btnVolver.Location = new System.Drawing.Point(27, 411);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(100, 28);
			this.btnVolver.TabIndex = 20;
			this.btnVolver.Text = "VOLVER";
			this.btnVolver.UseVisualStyleBackColor = true;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// RolPorFuncionalidadesModificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 452);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.txtNombreRol);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblLstFunc);
			this.Controls.Add(this.dgvFuncionalidades);
			this.Name = "RolPorFuncionalidadesModificar";
			this.Text = "RolPorFuncionalidadesModificar";
			this.Load += new System.EventHandler(this.RolPorFuncionalidadesModificar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFuncionalidades;
		private System.Windows.Forms.Label lblLstFunc;
		private System.Windows.Forms.TextBox txtNombreRol;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Button btnVolver;
	}
}