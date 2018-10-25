namespace FrbaDemo.RolesPorUsuario
{
	partial class AsignacionDeRolesPorUsuario
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
			this.dgvRoles = new System.Windows.Forms.DataGridView();
			this.lblLstFunc = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNombreRol = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRoles
			// 
			this.dgvRoles.AllowUserToAddRows = false;
			this.dgvRoles.AllowUserToDeleteRows = false;
			this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRoles.Location = new System.Drawing.Point(98, 153);
			this.dgvRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvRoles.Name = "dgvRoles";
			this.dgvRoles.Size = new System.Drawing.Size(609, 174);
			this.dgvRoles.TabIndex = 9;
			// 
			// lblLstFunc
			// 
			this.lblLstFunc.AutoSize = true;
			this.lblLstFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblLstFunc.Location = new System.Drawing.Point(94, 123);
			this.lblLstFunc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblLstFunc.Name = "lblLstFunc";
			this.lblLstFunc.Size = new System.Drawing.Size(142, 24);
			this.lblLstFunc.TabIndex = 8;
			this.lblLstFunc.Text = "Listado de roles";
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.btnGuardar.Location = new System.Drawing.Point(571, 60);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(136, 43);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// txtNombreRol
			// 
			this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.txtNombreRol.Location = new System.Drawing.Point(223, 56);
			this.txtNombreRol.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtNombreRol.Name = "txtNombreRol";
			this.txtNombreRol.Size = new System.Drawing.Size(319, 28);
			this.txtNombreRol.TabIndex = 14;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblNombre.Location = new System.Drawing.Point(50, 60);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(163, 24);
			this.lblNombre.TabIndex = 13;
			this.lblNombre.Text = "Descripcion de rol";
			// 
			// AsignacionDeRolesPorUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtNombreRol);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvRoles);
			this.Controls.Add(this.lblLstFunc);
			this.Name = "AsignacionDeRolesPorUsuario";
			this.Text = "AsignacionDeRolesPorUsuario";
			((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRoles;
		private System.Windows.Forms.Label lblLstFunc;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombreRol;
		private System.Windows.Forms.Label lblNombre;
	}
}