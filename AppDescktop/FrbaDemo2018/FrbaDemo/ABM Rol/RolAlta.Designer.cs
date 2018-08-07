namespace FrbaDemo.ABM_Rol
{
	partial class RolAlta
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
			this.lblRol = new System.Windows.Forms.Label();
			this.txtNombreRol = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.titulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblRol
			// 
			this.lblRol.AutoSize = true;
			this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblRol.Location = new System.Drawing.Point(111, 68);
			this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(147, 25);
			this.lblRol.TabIndex = 1;
			this.lblRol.Text = "Nombre de Rol:";
			this.lblRol.Click += new System.EventHandler(this.lblRol_Click);
			// 
			// txtNombreRol
			// 
			this.txtNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtNombreRol.Location = new System.Drawing.Point(290, 63);
			this.txtNombreRol.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombreRol.Name = "txtNombreRol";
			this.txtNombreRol.Size = new System.Drawing.Size(226, 30);
			this.txtNombreRol.TabIndex = 8;
			this.txtNombreRol.TextChanged += new System.EventHandler(this.txtNombreRol_TextChanged);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnGuardar.Location = new System.Drawing.Point(196, 113);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(181, 48);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// titulo
			// 
			this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(181, 9);
			this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(211, 37);
			this.titulo.TabIndex = 10;
			this.titulo.Text = "Listado de Roles";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RolAlta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 174);
			this.Controls.Add(this.titulo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombreRol);
			this.Controls.Add(this.lblRol);
			this.Name = "RolAlta";
			this.Text = "Alta de rol";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRol;
		private System.Windows.Forms.TextBox txtNombreRol;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label titulo;
	}
}