namespace FrbaDemo.ABM_Funcionalidad
{
	partial class FuncionalidadAlta
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
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.lblRol = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGuardar
			// 
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnGuardar.Location = new System.Drawing.Point(277, 235);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(181, 48);
			this.btnGuardar.TabIndex = 12;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtDescripcion.Location = new System.Drawing.Point(365, 168);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(226, 30);
			this.txtDescripcion.TabIndex = 11;
			// 
			// lblRol
			// 
			this.lblRol.AutoSize = true;
			this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblRol.Location = new System.Drawing.Point(210, 168);
			this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(120, 25);
			this.lblRol.TabIndex = 10;
			this.lblRol.Text = "Descripcion:";
			// 
			// FuncionalidadAlta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.lblRol);
			this.Name = "FuncionalidadAlta";
			this.Text = "FuncionalidadAlta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label lblRol;
	}
}