namespace FrbaDemo.ABM_Usuario
{
	partial class UsuarioAlta
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.titulo = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblNombre.Location = new System.Drawing.Point(46, 86);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(79, 24);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Usuario:";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblPassword.Location = new System.Drawing.Point(14, 136);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(111, 24);
			this.lblPassword.TabIndex = 6;
			this.lblPassword.Text = "Contraseña:";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtNombre.Location = new System.Drawing.Point(133, 80);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(302, 30);
			this.txtNombre.TabIndex = 9;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtContraseña.Location = new System.Drawing.Point(133, 130);
			this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.PasswordChar = '*';
			this.txtContraseña.Size = new System.Drawing.Size(302, 30);
			this.txtContraseña.TabIndex = 15;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnGuardar.Location = new System.Drawing.Point(305, 185);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(181, 48);
			this.btnGuardar.TabIndex = 16;
			this.btnGuardar.Text = "Registrar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// titulo
			// 
			this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(143, 10);
			this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(292, 46);
			this.titulo.TabIndex = 23;
			this.titulo.Text = "Registración de usuario";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(74, 185);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(181, 48);
			this.btnCancelar.TabIndex = 24;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// UsuarioAlta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 263);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.titulo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblNombre);
			this.Name = "UsuarioAlta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alta de Usuario";
			this.Load += new System.EventHandler(this.UsuarioAlta_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label titulo;
		private System.Windows.Forms.Button btnCancelar;
	}
}