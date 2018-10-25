namespace FrbaDemo.ABM_Usuario
{
	partial class UsuarioModificar
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtHiden = new System.Windows.Forms.TextBox();
			this.titulo = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtNombre.Location = new System.Drawing.Point(111, 95);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(421, 30);
			this.txtNombre.TabIndex = 18;
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblNombre.Location = new System.Drawing.Point(23, 97);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(79, 24);
			this.lblNombre.TabIndex = 16;
			this.lblNombre.Text = "Usuario:";
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.NavajoWhite;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnGuardar.Location = new System.Drawing.Point(351, 182);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(181, 48);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtHiden
			// 
			this.txtHiden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtHiden.Location = new System.Drawing.Point(112, 137);
			this.txtHiden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtHiden.Name = "txtHiden";
			this.txtHiden.PasswordChar = '*';
			this.txtHiden.Size = new System.Drawing.Size(156, 30);
			this.txtHiden.TabIndex = 21;
			this.txtHiden.Visible = false;
			// 
			// titulo
			// 
			this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(150, 20);
			this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(271, 38);
			this.titulo.TabIndex = 22;
			this.titulo.Text = "Edición de usuario";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnCancelar.Location = new System.Drawing.Point(111, 182);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(181, 48);
			this.btnCancelar.TabIndex = 23;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// UsuarioModificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(562, 263);
			this.ControlBox = false;
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.titulo);
			this.Controls.Add(this.txtHiden);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UsuarioModificar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edición de usuario";
			this.Load += new System.EventHandler(this.UsuarioModificar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtHiden;
		private System.Windows.Forms.Label titulo;
		private System.Windows.Forms.Button btnCancelar;
	}
}