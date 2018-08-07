namespace FrbaDemo.ABM_Rol
{
	partial class RolPorFuncionalidades
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
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.titulo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvFuncionalidades
			// 
			this.dgvFuncionalidades.AllowUserToAddRows = false;
			this.dgvFuncionalidades.AllowUserToDeleteRows = false;
			this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFuncionalidades.Location = new System.Drawing.Point(44, 193);
			this.dgvFuncionalidades.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvFuncionalidades.Name = "dgvFuncionalidades";
			this.dgvFuncionalidades.Size = new System.Drawing.Size(609, 174);
			this.dgvFuncionalidades.TabIndex = 5;
			// 
			// lblLstFunc
			// 
			this.lblLstFunc.AutoSize = true;
			this.lblLstFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblLstFunc.Location = new System.Drawing.Point(40, 163);
			this.lblLstFunc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblLstFunc.Name = "lblLstFunc";
			this.lblLstFunc.Size = new System.Drawing.Size(241, 24);
			this.lblLstFunc.TabIndex = 4;
			this.lblLstFunc.Text = "Listado de Funcionalidades";
			// 
			// txtNombreRol
			// 
			this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNombreRol.Location = new System.Drawing.Point(213, 115);
			this.txtNombreRol.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtNombreRol.Name = "txtNombreRol";
			this.txtNombreRol.Size = new System.Drawing.Size(319, 28);
			this.txtNombreRol.TabIndex = 9;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.btnGuardar.Location = new System.Drawing.Point(563, 100);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(136, 43);
			this.btnGuardar.TabIndex = 8;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblNombre.Location = new System.Drawing.Point(40, 119);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(163, 24);
			this.lblNombre.TabIndex = 7;
			this.lblNombre.Text = "Descripcion de rol";
			// 
			// titulo
			// 
			this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(281, 12);
			this.titulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(256, 0);
			this.titulo.TabIndex = 11;
			this.titulo.Text = "Alta de rol con funcionalidades";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RolPorFuncionalidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 384);
			this.Controls.Add(this.titulo);
			this.Controls.Add(this.txtNombreRol);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.dgvFuncionalidades);
			this.Controls.Add(this.lblLstFunc);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "RolPorFuncionalidades";
			this.Text = "RolPorFuncionalidades";
			this.Load += new System.EventHandler(this.RolPorFuncionalidades_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFuncionalidades;
		private System.Windows.Forms.Label lblLstFunc;
		private System.Windows.Forms.TextBox txtNombreRol;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label titulo;
	}
}