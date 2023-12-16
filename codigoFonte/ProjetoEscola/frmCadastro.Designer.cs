namespace ProjetoEscola
{
	partial class frmCadastro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.cbSexo = new System.Windows.Forms.ComboBox();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtObservacoes = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.MaskedTextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtCep = new System.Windows.Forms.MaskedTextBox();
			this.txtRg = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.msMenu = new System.Windows.Forms.MenuStrip();
			this.tsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPesquisa = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuEditar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPerfil = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.msMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(50, 105);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(297, 21);
			this.txtNome.TabIndex = 0;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(50, 204);
			this.txtTelefone.Mask = "(00)90000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(99, 21);
			this.txtTelefone.TabIndex = 4;
			this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// cbSexo
			// 
			this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSexo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSexo.FormattingEnabled = true;
			this.cbSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino",
            "Outros"});
			this.cbSexo.Location = new System.Drawing.Point(384, 105);
			this.cbSexo.Name = "cbSexo";
			this.cbSexo.Size = new System.Drawing.Size(121, 23);
			this.cbSexo.TabIndex = 1;
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNascimento.Location = new System.Drawing.Point(172, 204);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.Size = new System.Drawing.Size(97, 20);
			this.dtpNascimento.TabIndex = 5;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(51, 254);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(296, 21);
			this.txtEndereco.TabIndex = 6;
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.Location = new System.Drawing.Point(49, 351);
			this.txtObservacoes.Multiline = true;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(456, 101);
			this.txtObservacoes.TabIndex = 9;
			// 
			// txtCpf
			// 
			this.txtCpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(172, 152);
			this.txtCpf.Mask = "000,000,000-00";
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(100, 21);
			this.txtCpf.TabIndex = 3;
			this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(51, 301);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(183, 21);
			this.txtBairro.TabIndex = 7;
			// 
			// txtCep
			// 
			this.txtCep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCep.Location = new System.Drawing.Point(278, 301);
			this.txtCep.Mask = "99999-999";
			this.txtCep.Name = "txtCep";
			this.txtCep.Size = new System.Drawing.Size(69, 21);
			this.txtCep.TabIndex = 8;
			this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtRg
			// 
			this.txtRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRg.Location = new System.Drawing.Point(50, 152);
			this.txtRg.Mask = "00,000,000-09";
			this.txtRg.Name = "txtRg";
			this.txtRg.Size = new System.Drawing.Size(99, 21);
			this.txtRg.TabIndex = 2;
			this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(239, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 46);
			this.label1.TabIndex = 12;
			this.label1.Text = "Area de Cadastro";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 14);
			this.label2.TabIndex = 14;
			this.label2.Text = "Nome Completo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(48, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 14);
			this.label3.TabIndex = 15;
			this.label3.Text = "RG";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(169, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 14);
			this.label4.TabIndex = 16;
			this.label4.Text = "CPF";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(47, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 14);
			this.label5.TabIndex = 17;
			this.label5.Text = "Telefone";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(169, 187);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 14);
			this.label6.TabIndex = 18;
			this.label6.Text = "Nascimento";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(48, 237);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 14);
			this.label7.TabIndex = 19;
			this.label7.Text = "Endereço";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(48, 284);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 14);
			this.label8.TabIndex = 20;
			this.label8.Text = "Bairro";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(275, 284);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 14);
			this.label9.TabIndex = 21;
			this.label9.Text = "CEP";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(48, 334);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 14);
			this.label10.TabIndex = 22;
			this.label10.Text = "Observaçoes";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(381, 88);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(40, 14);
			this.label11.TabIndex = 23;
			this.label11.Text = "Sexo";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(302, 535);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(50, 14);
			this.label12.TabIndex = 24;
			this.label12.Text = "Salvar";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(407, 535);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(53, 14);
			this.label13.TabIndex = 25;
			this.label13.Text = "Limpar";
			// 
			// msMenu
			// 
			this.msMenu.BackColor = System.Drawing.Color.LightCyan;
			this.msMenu.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItem});
			this.msMenu.Location = new System.Drawing.Point(0, 0);
			this.msMenu.Name = "msMenu";
			this.msMenu.Size = new System.Drawing.Size(800, 24);
			this.msMenu.TabIndex = 26;
			// 
			// tsMenuItem
			// 
			this.tsMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuPrincipal,
            this.tsMenuPesquisa,
            this.tsMenuEditar,
            this.tsMenuPerfil});
			this.tsMenuItem.Image = global::ProjetoEscola.Properties.Resources.menu_burger;
			this.tsMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tsMenuItem.Name = "tsMenuItem";
			this.tsMenuItem.Size = new System.Drawing.Size(68, 20);
			this.tsMenuItem.Text = "MENU";
			this.tsMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tsMenuPrincipal
			// 
			this.tsMenuPrincipal.Image = global::ProjetoEscola.Properties.Resources.home;
			this.tsMenuPrincipal.Name = "tsMenuPrincipal";
			this.tsMenuPrincipal.Size = new System.Drawing.Size(180, 22);
			this.tsMenuPrincipal.Text = "Menu Principal";
			this.tsMenuPrincipal.Click += new System.EventHandler(this.tsMenuPrincipal_Click);
			// 
			// tsMenuPesquisa
			// 
			this.tsMenuPesquisa.Image = global::ProjetoEscola.Properties.Resources.search;
			this.tsMenuPesquisa.Name = "tsMenuPesquisa";
			this.tsMenuPesquisa.Size = new System.Drawing.Size(180, 22);
			this.tsMenuPesquisa.Text = "Pesquisa";
			this.tsMenuPesquisa.Click += new System.EventHandler(this.tsMenuPesquisa_Click);
			// 
			// tsMenuEditar
			// 
			this.tsMenuEditar.Image = global::ProjetoEscola.Properties.Resources.edit;
			this.tsMenuEditar.Name = "tsMenuEditar";
			this.tsMenuEditar.Size = new System.Drawing.Size(180, 22);
			this.tsMenuEditar.Text = "Editar Aluno";
			this.tsMenuEditar.Click += new System.EventHandler(this.tsMenuEditar_Click);
			// 
			// tsMenuPerfil
			// 
			this.tsMenuPerfil.Image = global::ProjetoEscola.Properties.Resources.user;
			this.tsMenuPerfil.Name = "tsMenuPerfil";
			this.tsMenuPerfil.Size = new System.Drawing.Size(180, 22);
			this.tsMenuPerfil.Text = "Perfil";
			this.tsMenuPerfil.Click += new System.EventHandler(this.tsMenuPerfil_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.White;
			this.btnLimpar.BackgroundImage = global::ProjetoEscola.Properties.Resources.limpa;
			this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpar.Location = new System.Drawing.Point(395, 467);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 65);
			this.btnLimpar.TabIndex = 11;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.White;
			this.btnSalvar.BackgroundImage = global::ProjetoEscola.Properties.Resources.Save_icon;
			this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalvar.Location = new System.Drawing.Point(289, 467);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 65);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::ProjetoEscola.Properties.Resources.crianca_escola;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(541, 123);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(262, 328);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(800, 565);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRg);
			this.Controls.Add(this.txtCep);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtCpf);
			this.Controls.Add(this.txtObservacoes);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.dtpNascimento);
			this.Controls.Add(this.cbSexo);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.msMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.msMenu;
			this.MaximizeBox = false;
			this.Name = "frmCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Aluno";
			this.msMenu.ResumeLayout(false);
			this.msMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.ComboBox cbSexo;
		private System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtObservacoes;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.MaskedTextBox txtCep;
		private System.Windows.Forms.MaskedTextBox txtRg;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.MenuStrip msMenu;
		private System.Windows.Forms.ToolStripMenuItem tsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPrincipal;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPesquisa;
		private System.Windows.Forms.ToolStripMenuItem tsMenuEditar;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPerfil;
	}
}