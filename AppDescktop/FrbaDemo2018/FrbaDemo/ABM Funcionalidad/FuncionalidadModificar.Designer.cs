namespace FrbaDemo.ABM_Funcionalidad
{
	partial class FuncionalidadModificar
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
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.lblFuncionalidad = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnActualizar.Location = new System.Drawing.Point(264, 161);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(181, 48);
			this.btnActualizar.TabIndex = 13;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtCodigo.Location = new System.Drawing.Point(338, 70);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(226, 30);
			this.txtCodigo.TabIndex = 18;
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblCodigo.Location = new System.Drawing.Point(183, 70);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(75, 25);
			this.lblCodigo.TabIndex = 17;
			this.lblCodigo.Text = "Codigo";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.txtDescripcion.Location = new System.Drawing.Point(338, 108);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(226, 30);
			this.txtDescripcion.TabIndex = 16;
			// 
			// lblFuncionalidad
			// 
			this.lblFuncionalidad.AutoSize = true;
			this.lblFuncionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lblFuncionalidad.Location = new System.Drawing.Point(183, 108);
			this.lblFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFuncionalidad.Name = "lblFuncionalidad";
			this.lblFuncionalidad.Size = new System.Drawing.Size(120, 25);
			this.lblFuncionalidad.TabIndex = 15;
			this.lblFuncionalidad.Text = "Descripcion:";
			// 
			// FuncionalidadModificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.lblFuncionalidad);
			this.Controls.Add(this.btnActualizar);
			this.Name = "FuncionalidadModificar";
			this.Text = "FuncionalidadModificar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label lblFuncionalidad;
	}
}