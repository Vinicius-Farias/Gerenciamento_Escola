namespace ProjetoEscola
{
	partial class frmNovaSenha
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaSenha));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gpbVerificaEmail = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.gpbCodigo = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnEnviarCodigo = new System.Windows.Forms.Button();
			this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNomeUsuario = new System.Windows.Forms.Label();
			this.gpbNovaSenha = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.ckbExibirSenha = new System.Windows.Forms.CheckBox();
			this.txtSenha2 = new System.Windows.Forms.TextBox();
			this.txtSenha1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gpbVerificaEmail.SuspendLayout();
			this.gpbCodigo.SuspendLayout();
			this.gpbNovaSenha.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::ProjetoEscola.Properties.Resources.redefiniSenha;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(142, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(145, 113);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LightCyan;
			this.label1.Font = new System.Drawing.Font("Georgia", 24.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(70, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "Redefinir senha";
			// 
			// gpbVerificaEmail
			// 
			this.gpbVerificaEmail.Controls.Add(this.label4);
			this.gpbVerificaEmail.Controls.Add(this.label3);
			this.gpbVerificaEmail.Controls.Add(this.label2);
			this.gpbVerificaEmail.Controls.Add(this.txtEmail);
			this.gpbVerificaEmail.Controls.Add(this.btnEnviar);
			this.gpbVerificaEmail.Location = new System.Drawing.Point(46, 185);
			this.gpbVerificaEmail.Name = "gpbVerificaEmail";
			this.gpbVerificaEmail.Size = new System.Drawing.Size(343, 224);
			this.gpbVerificaEmail.TabIndex = 2;
			this.gpbVerificaEmail.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 14);
			this.label4.TabIndex = 4;
			this.label4.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label3.Location = new System.Drawing.Point(16, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(188, 26);
			this.label3.TabIndex = 3;
			this.label3.Text = "Digite o Email que foi cadastrado junto\r\ncom seu cadastro";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.MediumBlue;
			this.label2.Location = new System.Drawing.Point(15, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 57);
			this.label2.TabIndex = 2;
			this.label2.Text = "Preencha os dados abaixo\r\npara solicitar a recuperação\r\nde senha.";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(19, 99);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(304, 20);
			this.txtEmail.TabIndex = 1;
			// 
			// btnEnviar
			// 
			this.btnEnviar.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEnviar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviar.ForeColor = System.Drawing.Color.White;
			this.btnEnviar.Location = new System.Drawing.Point(94, 174);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.Size = new System.Drawing.Size(165, 35);
			this.btnEnviar.TabIndex = 0;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.UseVisualStyleBackColor = false;
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnVoltar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.ForeColor = System.Drawing.Color.White;
			this.btnVoltar.Location = new System.Drawing.Point(360, 415);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(75, 33);
			this.btnVoltar.TabIndex = 3;
			this.btnVoltar.Text = "< Voltar";
			this.btnVoltar.UseVisualStyleBackColor = false;
			this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
			// 
			// gpbCodigo
			// 
			this.gpbCodigo.Controls.Add(this.linkLabel1);
			this.gpbCodigo.Controls.Add(this.btnEnviarCodigo);
			this.gpbCodigo.Controls.Add(this.txtCodigo);
			this.gpbCodigo.Controls.Add(this.label5);
			this.gpbCodigo.Controls.Add(this.lblNomeUsuario);
			this.gpbCodigo.Location = new System.Drawing.Point(132, 184);
			this.gpbCodigo.Name = "gpbCodigo";
			this.gpbCodigo.Size = new System.Drawing.Size(174, 185);
			this.gpbCodigo.TabIndex = 4;
			this.gpbCodigo.TabStop = false;
			this.gpbCodigo.Visible = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(6, 166);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(86, 13);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Reenviar Código";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// btnEnviarCodigo
			// 
			this.btnEnviarCodigo.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnEnviarCodigo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnviarCodigo.ForeColor = System.Drawing.Color.White;
			this.btnEnviarCodigo.Location = new System.Drawing.Point(54, 126);
			this.btnEnviarCodigo.Name = "btnEnviarCodigo";
			this.btnEnviarCodigo.Size = new System.Drawing.Size(75, 30);
			this.btnEnviarCodigo.TabIndex = 4;
			this.btnEnviarCodigo.Text = "Enviar";
			this.btnEnviarCodigo.UseVisualStyleBackColor = false;
			this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(45, 84);
			this.txtCodigo.Mask = "000000";
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(92, 25);
			this.txtCodigo.TabIndex = 3;
			this.txtCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 26);
			this.label5.TabIndex = 2;
			this.label5.Text = "Digite o código que enviamos\r\n para seu Email";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNomeUsuario
			// 
			this.lblNomeUsuario.AutoSize = true;
			this.lblNomeUsuario.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomeUsuario.ForeColor = System.Drawing.Color.MediumBlue;
			this.lblNomeUsuario.Location = new System.Drawing.Point(29, 16);
			this.lblNomeUsuario.Name = "lblNomeUsuario";
			this.lblNomeUsuario.Size = new System.Drawing.Size(0, 22);
			this.lblNomeUsuario.TabIndex = 0;
			// 
			// gpbNovaSenha
			// 
			this.gpbNovaSenha.Controls.Add(this.label8);
			this.gpbNovaSenha.Controls.Add(this.label7);
			this.gpbNovaSenha.Controls.Add(this.btnSalvar);
			this.gpbNovaSenha.Controls.Add(this.ckbExibirSenha);
			this.gpbNovaSenha.Controls.Add(this.txtSenha2);
			this.gpbNovaSenha.Controls.Add(this.txtSenha1);
			this.gpbNovaSenha.Controls.Add(this.label6);
			this.gpbNovaSenha.Location = new System.Drawing.Point(56, 182);
			this.gpbNovaSenha.Name = "gpbNovaSenha";
			this.gpbNovaSenha.Size = new System.Drawing.Size(322, 224);
			this.gpbNovaSenha.TabIndex = 5;
			this.gpbNovaSenha.TabStop = false;
			this.gpbNovaSenha.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(31, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 14);
			this.label8.TabIndex = 6;
			this.label8.Text = "Repita a senha";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(31, 51);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(39, 14);
			this.label7.TabIndex = 5;
			this.label7.Text = "Senha";
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnSalvar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.Location = new System.Drawing.Point(138, 174);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 30);
			this.btnSalvar.TabIndex = 4;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// ckbExibirSenha
			// 
			this.ckbExibirSenha.AutoSize = true;
			this.ckbExibirSenha.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbExibirSenha.Location = new System.Drawing.Point(34, 145);
			this.ckbExibirSenha.Name = "ckbExibirSenha";
			this.ckbExibirSenha.Size = new System.Drawing.Size(95, 18);
			this.ckbExibirSenha.TabIndex = 3;
			this.ckbExibirSenha.Text = "Exibir Senha";
			this.ckbExibirSenha.UseVisualStyleBackColor = true;
			this.ckbExibirSenha.CheckedChanged += new System.EventHandler(this.ckbExibirSenha_CheckedChanged);
			// 
			// txtSenha2
			// 
			this.txtSenha2.Location = new System.Drawing.Point(34, 107);
			this.txtSenha2.Name = "txtSenha2";
			this.txtSenha2.PasswordChar = '*';
			this.txtSenha2.Size = new System.Drawing.Size(241, 20);
			this.txtSenha2.TabIndex = 2;
			// 
			// txtSenha1
			// 
			this.txtSenha1.Location = new System.Drawing.Point(34, 65);
			this.txtSenha1.Name = "txtSenha1";
			this.txtSenha1.PasswordChar = '*';
			this.txtSenha1.Size = new System.Drawing.Size(241, 20);
			this.txtSenha1.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.MediumBlue;
			this.label6.Location = new System.Drawing.Point(22, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(277, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Crier uma nova senha para seu úsuario";
			// 
			// frmNovaSenha
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.BackgroundImage = global::ProjetoEscola.Properties.Resources.Fundo_escola;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(438, 450);
			this.Controls.Add(this.gpbNovaSenha);
			this.Controls.Add(this.gpbCodigo);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.gpbVerificaEmail);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNovaSenha";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Redefinir Senha";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gpbVerificaEmail.ResumeLayout(false);
			this.gpbVerificaEmail.PerformLayout();
			this.gpbCodigo.ResumeLayout(false);
			this.gpbCodigo.PerformLayout();
			this.gpbNovaSenha.ResumeLayout(false);
			this.gpbNovaSenha.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gpbVerificaEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnEnviar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnVoltar;
		private System.Windows.Forms.GroupBox gpbCodigo;
		private System.Windows.Forms.Label lblNomeUsuario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox txtCodigo;
		private System.Windows.Forms.Button btnEnviarCodigo;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.GroupBox gpbNovaSenha;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.CheckBox ckbExibirSenha;
		private System.Windows.Forms.TextBox txtSenha2;
		private System.Windows.Forms.TextBox txtSenha1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}