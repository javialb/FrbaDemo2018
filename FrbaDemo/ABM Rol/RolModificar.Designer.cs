namespace FrbaDemo.ABM_Rol
{
	partial class RolModificar
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
			this.btnActualizar = new System.Windows.Forms.Button();
			this.txtNombreRol = new System.Windows.Forms.TextBox();
			this.lblRol = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnActualizar.Location = new System.Drawing.Point(172, 98);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(181, 48);
			this.btnActualizar.TabIndex = 12;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// txtNombreRol
			// 
			this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtNombreRol.Location = new System.Drawing.Point(265, 54);
			this.txtNombreRol.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombreRol.Name = "txtNombreRol";
			this.txtNombreRol.Size = new System.Drawing.Size(226, 30);
			this.txtNombreRol.TabIndex = 11;
			// 
			// lblRol
			// 
			this.lblRol.AutoSize = true;
			this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblRol.Location = new System.Drawing.Point(110, 54);
			this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(147, 25);
			this.lblRol.TabIndex = 10;
			this.lblRol.Text = "Nombre de Rol:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtCodigo.Location = new System.Drawing.Point(265, 16);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(226, 30);
			this.txtCodigo.TabIndex = 14;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCodigo.Location = new System.Drawing.Point(110, 16);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(75, 25);
			this.lblCodigo.TabIndex = 13;
			this.lblCodigo.Text = "Codigo";
			// 
			// RolModificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 193);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.txtNombreRol);
			this.Controls.Add(this.lblRol);
			this.Name = "RolModificar";
			this.Text = "Modificacion de  rol";
			this.Load += new System.EventHandler(this.RolModificar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtNombreRol;
		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
	}
}