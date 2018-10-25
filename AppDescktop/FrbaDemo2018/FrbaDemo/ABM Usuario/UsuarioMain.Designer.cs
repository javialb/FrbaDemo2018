namespace FrbaDemo.ABM_Usuario
{
	partial class UsuarioMain
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
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			btnAlta = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAlta
			// 
			btnAlta.BackColor = System.Drawing.SystemColors.ActiveCaption;
			btnAlta.ForeColor = System.Drawing.SystemColors.ControlText;
			btnAlta.Location = new System.Drawing.Point(16, 88);
			btnAlta.Margin = new System.Windows.Forms.Padding(5);
			btnAlta.Name = "btnAlta";
			btnAlta.Size = new System.Drawing.Size(201, 41);
			btnAlta.TabIndex = 14;
			btnAlta.Text = "Nuevo usuario";
			btnAlta.UseVisualStyleBackColor = false;
			btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
			// 
			// titulo
			// 
			this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titulo.Location = new System.Drawing.Point(249, 32);
			this.titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.titulo.Name = "titulo";
			this.titulo.Size = new System.Drawing.Size(275, 37);
			this.titulo.TabIndex = 13;
			this.titulo.Text = "Listado de usuarios";
			this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.AllowUserToDeleteRows = false;
			this.dgvUsuarios.AllowUserToResizeColumns = false;
			this.dgvUsuarios.AllowUserToResizeRows = false;
			this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlDark;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(16, 149);
			this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(5);
			this.dgvUsuarios.MultiSelect = false;
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsuarios.Size = new System.Drawing.Size(770, 238);
			this.dgvUsuarios.TabIndex = 15;
			// 
			// UsuarioMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvUsuarios);
			this.Controls.Add(btnAlta);
			this.Controls.Add(this.titulo);
			this.Name = "UsuarioMain";
			this.Text = "UsuarioMain";
			this.Load += new System.EventHandler(this.UsuarioMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titulo;
		private System.Windows.Forms.DataGridView dgvUsuarios;
	}
}