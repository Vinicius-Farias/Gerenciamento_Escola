namespace ProjetoEscola
{
	partial class frmExcluirLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcluirLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.rbUsuario = new System.Windows.Forms.RadioButton();
			this.rbEmail = new System.Windows.Forms.RadioButton();
			this.dtgPesquisa = new System.Windows.Forms.DataGridView();
			this.ID_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.USUARIO_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NIVEL_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMAIL_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(119, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Excluir Login";
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(63, 104);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(340, 20);
			this.txtPesquisa.TabIndex = 1;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// rbUsuario
			// 
			this.rbUsuario.AutoSize = true;
			this.rbUsuario.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbUsuario.Location = new System.Drawing.Point(113, 152);
			this.rbUsuario.Name = "rbUsuario";
			this.rbUsuario.Size = new System.Drawing.Size(120, 18);
			this.rbUsuario.TabIndex = 2;
			this.rbUsuario.TabStop = true;
			this.rbUsuario.Text = "Nome de Úsuario";
			this.rbUsuario.UseVisualStyleBackColor = true;
			// 
			// rbEmail
			// 
			this.rbEmail.AutoSize = true;
			this.rbEmail.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbEmail.Location = new System.Drawing.Point(274, 152);
			this.rbEmail.Name = "rbEmail";
			this.rbEmail.Size = new System.Drawing.Size(57, 18);
			this.rbEmail.TabIndex = 3;
			this.rbEmail.TabStop = true;
			this.rbEmail.Text = "Email";
			this.rbEmail.UseVisualStyleBackColor = true;
			// 
			// dtgPesquisa
			// 
			this.dtgPesquisa.AllowUserToAddRows = false;
			this.dtgPesquisa.AllowUserToDeleteRows = false;
			this.dtgPesquisa.AllowUserToResizeColumns = false;
			this.dtgPesquisa.AllowUserToResizeRows = false;
			this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_LOGIN,
            this.USUARIO_LOGIN,
            this.NIVEL_LOGIN,
            this.EMAIL_LOGIN,
            this.btnExcluir});
			this.dtgPesquisa.Location = new System.Drawing.Point(8, 185);
			this.dtgPesquisa.MultiSelect = false;
			this.dtgPesquisa.Name = "dtgPesquisa";
			this.dtgPesquisa.ReadOnly = true;
			this.dtgPesquisa.RowHeadersVisible = false;
			this.dtgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgPesquisa.Size = new System.Drawing.Size(455, 253);
			this.dtgPesquisa.TabIndex = 4;
			this.dtgPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisa_CellContentClick);
			// 
			// ID_LOGIN
			// 
			this.ID_LOGIN.DataPropertyName = "ID_LOGIN";
			this.ID_LOGIN.HeaderText = "ID_LOGIN";
			this.ID_LOGIN.Name = "ID_LOGIN";
			this.ID_LOGIN.ReadOnly = true;
			this.ID_LOGIN.Visible = false;
			// 
			// USUARIO_LOGIN
			// 
			this.USUARIO_LOGIN.DataPropertyName = "USUARIO_LOGIN";
			this.USUARIO_LOGIN.HeaderText = "Nome de Úsuario";
			this.USUARIO_LOGIN.Name = "USUARIO_LOGIN";
			this.USUARIO_LOGIN.ReadOnly = true;
			this.USUARIO_LOGIN.Width = 135;
			// 
			// NIVEL_LOGIN
			// 
			this.NIVEL_LOGIN.DataPropertyName = "NIVEL_LOGIN";
			this.NIVEL_LOGIN.HeaderText = "Nivel";
			this.NIVEL_LOGIN.Name = "NIVEL_LOGIN";
			this.NIVEL_LOGIN.ReadOnly = true;
			this.NIVEL_LOGIN.Width = 126;
			// 
			// EMAIL_LOGIN
			// 
			this.EMAIL_LOGIN.DataPropertyName = "EMAIL_LOGIN";
			this.EMAIL_LOGIN.HeaderText = "Email";
			this.EMAIL_LOGIN.Name = "EMAIL_LOGIN";
			this.EMAIL_LOGIN.ReadOnly = true;
			this.EMAIL_LOGIN.Width = 140;
			// 
			// btnExcluir
			// 
			this.btnExcluir.HeaderText = "";
			this.btnExcluir.Image = global::ProjetoEscola.Properties.Resources.excluir2;
			this.btnExcluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.ReadOnly = true;
			this.btnExcluir.Width = 30;
			// 
			// frmExcluirLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.BackgroundImage = global::ProjetoEscola.Properties.Resources.Fundo_escola;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(472, 450);
			this.Controls.Add(this.dtgPesquisa);
			this.Controls.Add(this.rbEmail);
			this.Controls.Add(this.rbUsuario);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmExcluirLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Excluir Login";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmExcluirLogin_FormClosed);
			this.Load += new System.EventHandler(this.frmExcluirLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.RadioButton rbUsuario;
		private System.Windows.Forms.RadioButton rbEmail;
		private System.Windows.Forms.DataGridView dtgPesquisa;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_LOGIN;
		private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO_LOGIN;
		private System.Windows.Forms.DataGridViewTextBoxColumn NIVEL_LOGIN;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL_LOGIN;
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
	}
}