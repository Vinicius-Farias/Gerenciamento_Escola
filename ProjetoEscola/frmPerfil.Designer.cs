namespace ProjetoEscola
{
	partial class frmPerfil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.lblInformacao = new System.Windows.Forms.Label();
			this.btnSim = new System.Windows.Forms.Button();
			this.gpbAlteraLogin = new System.Windows.Forms.GroupBox();
			this.gpbAlteraSenha = new System.Windows.Forms.GroupBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSenha2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.ckbExibiSenha = new System.Windows.Forms.CheckBox();
			this.btnAlteraSenha = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAltera = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNomeUsuario = new System.Windows.Forms.TextBox();
			this.gpbAlteraLogin.SuspendLayout();
			this.gpbAlteraSenha.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.AutoSize = true;
			this.lblNomeUsuario.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNomeUsuario.Location = new System.Drawing.Point(119, 9);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(181, 39);
			this.lblNomeUsuario.TabIndex = 0;
			this.lblNomeUsuario.Text = "Óla Vinicius";
			// 
			// lblInformacao
			// 
			this.lblInformacao.AutoSize = true;
			this.lblInformacao.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInformacao.Location = new System.Drawing.Point(28, 106);
			this.lblInformacao.Name = "lblInformacao";
			this.lblInformacao.Size = new System.Drawing.Size(358, 38);
			this.lblInformacao.TabIndex = 1;
			this.lblInformacao.Text = "Você desseja fazer alteraçôes no seu Login?\r\nOps você não podera mudar seu nivel " +
    "de Login!";
			this.lblInformacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSim
			// 
			this.btnSim.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnSim.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSim.ForeColor = System.Drawing.Color.White;
			this.btnSim.Location = new System.Drawing.Point(166, 191);
			this.btnSim.Name = "btnSim";
			this.btnSim.Size = new System.Drawing.Size(75, 29);
			this.btnSim.TabIndex = 2;
			this.btnSim.Text = "SIM";
			this.btnSim.UseVisualStyleBackColor = false;
			this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
			// 
			// gpbAlteraLogin
			// 
			this.gpbAlteraLogin.Controls.Add(this.gpbAlteraSenha);
			this.gpbAlteraLogin.Controls.Add(this.btnAlteraSenha);
			this.gpbAlteraLogin.Controls.Add(this.label5);
			this.gpbAlteraLogin.Controls.Add(this.label2);
			this.gpbAlteraLogin.Controls.Add(this.label1);
			this.gpbAlteraLogin.Controls.Add(this.btnAltera);
			this.gpbAlteraLogin.Controls.Add(this.txtEmail);
			this.gpbAlteraLogin.Controls.Add(this.txtNomeUsuario);
			this.gpbAlteraLogin.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbAlteraLogin.Location = new System.Drawing.Point(12, 85);
			this.gpbAlteraLogin.Name = "gpbAlteraLogin";
			this.gpbAlteraLogin.Size = new System.Drawing.Size(391, 278);
			this.gpbAlteraLogin.TabIndex = 3;
			this.gpbAlteraLogin.TabStop = false;
			this.gpbAlteraLogin.Text = "Alteração de Login";
			this.gpbAlteraLogin.Visible = false;
			// 
			// gpbAlteraSenha
			// 
			this.gpbAlteraSenha.Controls.Add(this.txtSenha);
			this.gpbAlteraSenha.Controls.Add(this.label3);
			this.gpbAlteraSenha.Controls.Add(this.txtSenha2);
			this.gpbAlteraSenha.Controls.Add(this.label4);
			this.gpbAlteraSenha.Controls.Add(this.ckbExibiSenha);
			this.gpbAlteraSenha.Location = new System.Drawing.Point(18, 141);
			this.gpbAlteraSenha.Name = "gpbAlteraSenha";
			this.gpbAlteraSenha.Size = new System.Drawing.Size(354, 96);
			this.gpbAlteraSenha.TabIndex = 10;
			this.gpbAlteraSenha.TabStop = false;
			this.gpbAlteraSenha.Visible = false;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(6, 26);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(228, 22);
			this.txtSenha.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 14);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nova Senha";
			// 
			// txtSenha2
			// 
			this.txtSenha2.Location = new System.Drawing.Point(6, 70);
			this.txtSenha2.Name = "txtSenha2";
			this.txtSenha2.PasswordChar = '*';
			this.txtSenha2.Size = new System.Drawing.Size(228, 22);
			this.txtSenha2.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 14);
			this.label4.TabIndex = 9;
			this.label4.Text = "Repita a Senha ";
			// 
			// ckbExibiSenha
			// 
			this.ckbExibiSenha.AutoSize = true;
			this.ckbExibiSenha.Location = new System.Drawing.Point(257, 49);
			this.ckbExibiSenha.Name = "ckbExibiSenha";
			this.ckbExibiSenha.Size = new System.Drawing.Size(95, 18);
			this.ckbExibiSenha.TabIndex = 5;
			this.ckbExibiSenha.Text = "Exibir Senha";
			this.ckbExibiSenha.UseVisualStyleBackColor = true;
			this.ckbExibiSenha.CheckedChanged += new System.EventHandler(this.ckbExibiSenha_CheckedChanged);
			// 
			// btnAlteraSenha
			// 
			this.btnAlteraSenha.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnAlteraSenha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAlteraSenha.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlteraSenha.ForeColor = System.Drawing.Color.White;
			this.btnAlteraSenha.Location = new System.Drawing.Point(154, 200);
			this.btnAlteraSenha.Name = "btnAlteraSenha";
			this.btnAlteraSenha.Size = new System.Drawing.Size(75, 23);
			this.btnAlteraSenha.TabIndex = 0;
			this.btnAlteraSenha.Text = "SIM";
			this.btnAlteraSenha.UseVisualStyleBackColor = false;
			this.btnAlteraSenha.Click += new System.EventHandler(this.btnAlteraSenha_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(111, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(197, 14);
			this.label5.TabIndex = 1;
			this.label5.Text = "Você que fazer alteração na senha?";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 14);
			this.label2.TabIndex = 7;
			this.label2.Text = "Novo Email";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 14);
			this.label1.TabIndex = 6;
			this.label1.Text = "Novo nome de Úsuario";
			// 
			// btnAltera
			// 
			this.btnAltera.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnAltera.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAltera.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAltera.ForeColor = System.Drawing.Color.White;
			this.btnAltera.Location = new System.Drawing.Point(153, 243);
			this.btnAltera.Name = "btnAltera";
			this.btnAltera.Size = new System.Drawing.Size(75, 29);
			this.btnAltera.TabIndex = 4;
			this.btnAltera.Text = "Alterar";
			this.btnAltera.UseVisualStyleBackColor = false;
			this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(25, 106);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(228, 22);
			this.txtEmail.TabIndex = 1;
			// 
			// txtNomeUsuario
			// 
			this.txtNomeUsuario.Location = new System.Drawing.Point(25, 51);
			this.txtNomeUsuario.Name = "txtNomeUsuario";
			this.txtNomeUsuario.Size = new System.Drawing.Size(228, 22);
			this.txtNomeUsuario.TabIndex = 0;
			// 
			// frmPerfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(415, 375);
			this.Controls.Add(this.gpbAlteraLogin);
			this.Controls.Add(this.btnSim);
			this.Controls.Add(this.lblInformacao);
			this.Controls.Add(this.lblNomeUsuario);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPerfil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Perfil";
			this.Load += new System.EventHandler(this.frmPerfil_Load);
			this.gpbAlteraLogin.ResumeLayout(false);
			this.gpbAlteraLogin.PerformLayout();
			this.gpbAlteraSenha.ResumeLayout(false);
			this.gpbAlteraSenha.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.Label lblInformacao;
		private System.Windows.Forms.Button btnSim;
		private System.Windows.Forms.GroupBox gpbAlteraLogin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox ckbExibiSenha;
		private System.Windows.Forms.Button btnAltera;
		private System.Windows.Forms.TextBox txtSenha2;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtNomeUsuario;
		private System.Windows.Forms.Button btnAlteraSenha;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox gpbAlteraSenha;
	}
}