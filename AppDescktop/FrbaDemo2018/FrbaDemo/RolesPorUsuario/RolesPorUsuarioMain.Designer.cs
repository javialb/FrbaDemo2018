namespace FrbaDemo.RolesPorUsuario
{
	partial class RolesPorUsuarioMain
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
			((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRoles
			// 
			this.dgvRoles.AllowUserToAddRows = false;
			this.dgvRoles.AllowUserToDeleteRows = false;
			this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRoles.Location = new System.Drawing.Point(102, 185);
			this.dgvRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvRoles.Name = "dgvRoles";
			this.dgvRoles.Size = new System.Drawing.Size(609, 174);
			this.dgvRoles.TabIndex = 7;
			// 
			// lblLstFunc
			// 
			this.lblLstFunc.AutoSize = true;
			this.lblLstFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.lblLstFunc.Location = new System.Drawing.Point(98, 155);
			this.lblLstFunc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblLstFunc.Name = "lblLstFunc";
			this.lblLstFunc.Size = new System.Drawing.Size(142, 24);
			this.lblLstFunc.TabIndex = 6;
			this.lblLstFunc.Text = "Listado de roles";
			// 
			// RolesPorUsuarioMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvRoles);
			this.Controls.Add(this.lblLstFunc);
			this.Name = "RolesPorUsuarioMain";
			this.Text = "RolesPorUsuarioMain";
			this.Load += new System.EventHandler(this.RolesPorUsuarioMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRoles;
		private System.Windows.Forms.Label lblLstFunc;
	}
}