namespace ProjetoEscola
{
	partial class frmEntraLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntraLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ckbExibirSenha = new System.Windows.Forms.CheckBox();
			this.lblLinkSenha = new System.Windows.Forms.LinkLabel();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLinkPrepara = new System.Windows.Forms.LinkLabel();
			this.btnSair = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::ProjetoEscola.Properties.Resources.crianca_escola;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(407, 64);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(234, 323);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(23, 60);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(224, 22);
			this.txtUsuario.TabIndex = 1;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(23, 124);
			this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(224, 22);
			this.txtSenha.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 14);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nome de Úsuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 110);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 14);
			this.label2.TabIndex = 4;
			this.label2.Text = "Senha";
			// 
			// ckbExibirSenha
			// 
			this.ckbExibirSenha.AutoSize = true;
			this.ckbExibirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ckbExibirSenha.Location = new System.Drawing.Point(23, 172);
			this.ckbExibirSenha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ckbExibirSenha.Name = "ckbExibirSenha";
			this.ckbExibirSenha.Size = new System.Drawing.Size(95, 18);
			this.ckbExibirSenha.TabIndex = 3;
			this.ckbExibirSenha.Text = "Exibir Senha";
			this.ckbExibirSenha.UseVisualStyleBackColor = true;
			this.ckbExibirSenha.CheckedChanged += new System.EventHandler(this.ckbExibirSenha_CheckedChanged);
			// 
			// lblLinkSenha
			// 
			this.lblLinkSenha.AutoSize = true;
			this.lblLinkSenha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblLinkSenha.Location = new System.Drawing.Point(48, 335);
			this.lblLinkSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLinkSenha.Name = "lblLinkSenha";
			this.lblLinkSenha.Size = new System.Drawing.Size(192, 14);
			this.lblLinkSenha.TabIndex = 6;
			this.lblLinkSenha.TabStop = true;
			this.lblLinkSenha.Text = "Esqueceu sua senha. Clique Aqui..";
			this.lblLinkSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkSenha_LinkClicked);
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.btnEntrar.ForeColor = System.Drawing.Color.White;
			this.btnEntrar.Location = new System.Drawing.Point(45, 232);
			this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(88, 42);
			this.btnEntrar.TabIndex = 4;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.LightCyan;
			this.label3.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label3.Location = new System.Drawing.Point(301, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(318, 38);
			this.label3.TabIndex = 8;
			this.label3.Text = "SEJA BEM VINDO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.LightCyan;
			this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label4.Location = new System.Drawing.Point(357, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(191, 36);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ao Sistema de Cadastro \r\ne Controle de Alunos\r\n";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label5.Location = new System.Drawing.Point(0, 374);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(361, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = " Sistema desenvolvido por: Vinicius de Farias Aluno da Escola: ";
			// 
			// lblLinkPrepara
			// 
			this.lblLinkPrepara.AutoSize = true;
			this.lblLinkPrepara.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblLinkPrepara.Location = new System.Drawing.Point(357, 374);
			this.lblLinkPrepara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLinkPrepara.Name = "lblLinkPrepara";
			this.lblLinkPrepara.Size = new System.Drawing.Size(93, 14);
			this.lblLinkPrepara.TabIndex = 7;
			this.lblLinkPrepara.TabStop = true;
			this.lblLinkPrepara.Text = "Prepara Cursos";
			this.lblLinkPrepara.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkPrepara_LinkClicked);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(141, 232);
			this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(88, 42);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// frmEntraLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.BackgroundImage = global::ProjetoEscola.Properties.Resources.Fundo_escola;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(654, 388);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblLinkPrepara);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.lblLinkSenha);
			this.Controls.Add(this.ckbExibirSenha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmEntraLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.frmEntraLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox ckbExibirSenha;
		private System.Windows.Forms.LinkLabel lblLinkSenha;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel lblLinkPrepara;
		private System.Windows.Forms.Button btnSair;
	}
}