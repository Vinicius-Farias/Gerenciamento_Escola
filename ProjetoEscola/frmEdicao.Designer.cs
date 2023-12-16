namespace ProjetoEscola
{
	partial class frmEdicao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdicao));
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.txtCp = new System.Windows.Forms.MaskedTextBox();
			this.cbSexo = new System.Windows.Forms.ComboBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtObservacoes = new System.Windows.Forms.TextBox();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtCpf = new System.Windows.Forms.MaskedTextBox();
			this.txtRg = new System.Windows.Forms.MaskedTextBox();
			this.txtRegistro = new System.Windows.Forms.TextBox();
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
			this.gbEdicao = new System.Windows.Forms.GroupBox();
			this.lblExcluir = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.lblEdicao = new System.Windows.Forms.Label();
			this.btnSelecionar = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mtsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPesquisa = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPerfil = new System.Windows.Forms.ToolStripMenuItem();
			this.gbEdicao.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.White;
			this.btnSalvar.BackgroundImage = global::ProjetoEscola.Properties.Resources.Save_icon;
			this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Location = new System.Drawing.Point(94, 432);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 65);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.White;
			this.btnLimpar.BackgroundImage = global::ProjetoEscola.Properties.Resources.limpa;
			this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpar.Location = new System.Drawing.Point(209, 432);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 65);
			this.btnLimpar.TabIndex = 11;
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.Color.White;
			this.btnExcluir.BackgroundImage = global::ProjetoEscola.Properties.Resources.excluir;
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Location = new System.Drawing.Point(323, 432);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 65);
			this.btnExcluir.TabIndex = 12;
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNascimento.Location = new System.Drawing.Point(160, 173);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.Size = new System.Drawing.Size(100, 20);
			this.dtpNascimento.TabIndex = 5;
			// 
			// txtCp
			// 
			this.txtCp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCp.Location = new System.Drawing.Point(244, 271);
			this.txtCp.Mask = "99999-999";
			this.txtCp.Name = "txtCp";
			this.txtCp.Size = new System.Drawing.Size(80, 21);
			this.txtCp.TabIndex = 8;
			this.txtCp.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// cbSexo
			// 
			this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSexo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSexo.FormattingEnabled = true;
			this.cbSexo.IntegralHeight = false;
			this.cbSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino",
            "Outros"});
			this.cbSexo.Location = new System.Drawing.Point(354, 82);
			this.cbSexo.Name = "cbSexo";
			this.cbSexo.Size = new System.Drawing.Size(123, 23);
			this.cbSexo.TabIndex = 1;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(29, 82);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(295, 21);
			this.txtNome.TabIndex = 0;
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(31, 271);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(184, 21);
			this.txtBairro.TabIndex = 7;
			// 
			// txtObservacoes
			// 
			this.txtObservacoes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacoes.Location = new System.Drawing.Point(31, 320);
			this.txtObservacoes.Multiline = true;
			this.txtObservacoes.Name = "txtObservacoes";
			this.txtObservacoes.Size = new System.Drawing.Size(446, 90);
			this.txtObservacoes.TabIndex = 9;
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(31, 173);
			this.txtTelefone.Mask = "(00) 90000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(104, 21);
			this.txtTelefone.TabIndex = 4;
			this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(31, 221);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(293, 21);
			this.txtEndereco.TabIndex = 6;
			// 
			// txtCpf
			// 
			this.txtCpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(160, 128);
			this.txtCpf.Mask = "000,000,000-00";
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(104, 21);
			this.txtCpf.TabIndex = 3;
			this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtRg
			// 
			this.txtRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRg.Location = new System.Drawing.Point(31, 128);
			this.txtRg.Mask = "00,000,000-09";
			this.txtRg.Name = "txtRg";
			this.txtRg.Size = new System.Drawing.Size(104, 21);
			this.txtRg.TabIndex = 2;
			this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// txtRegistro
			// 
			this.txtRegistro.Enabled = false;
			this.txtRegistro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRegistro.Location = new System.Drawing.Point(29, 38);
			this.txtRegistro.Name = "txtRegistro";
			this.txtRegistro.Size = new System.Drawing.Size(60, 21);
			this.txtRegistro.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(441, 46);
			this.label1.TabIndex = 14;
			this.label1.Text = "Area de Edição e Exclusão";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 15;
			this.label2.Text = "Registro";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 15);
			this.label3.TabIndex = 16;
			this.label3.Text = "Nome Completo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 15);
			this.label4.TabIndex = 17;
			this.label4.Text = "RG";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(157, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 15);
			this.label5.TabIndex = 18;
			this.label5.Text = "CPF";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(28, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 15);
			this.label6.TabIndex = 19;
			this.label6.Text = "Telefone";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(157, 155);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 15);
			this.label7.TabIndex = 20;
			this.label7.Text = "Nascimento";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(28, 203);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 15);
			this.label8.TabIndex = 21;
			this.label8.Text = "Endereço";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(28, 253);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 15);
			this.label9.TabIndex = 22;
			this.label9.Text = "Bairro";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(241, 253);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(30, 15);
			this.label10.TabIndex = 23;
			this.label10.Text = "CEP";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(351, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(36, 15);
			this.label11.TabIndex = 24;
			this.label11.Text = "Sexo";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(28, 302);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(83, 15);
			this.label12.TabIndex = 25;
			this.label12.Text = "Observaçoes";
			// 
			// gbEdicao
			// 
			this.gbEdicao.BackColor = System.Drawing.Color.Transparent;
			this.gbEdicao.Controls.Add(this.lblExcluir);
			this.gbEdicao.Controls.Add(this.label14);
			this.gbEdicao.Controls.Add(this.label13);
			this.gbEdicao.Controls.Add(this.label12);
			this.gbEdicao.Controls.Add(this.label6);
			this.gbEdicao.Controls.Add(this.label7);
			this.gbEdicao.Controls.Add(this.dtpNascimento);
			this.gbEdicao.Controls.Add(this.txtObservacoes);
			this.gbEdicao.Controls.Add(this.txtTelefone);
			this.gbEdicao.Controls.Add(this.btnSalvar);
			this.gbEdicao.Controls.Add(this.txtRegistro);
			this.gbEdicao.Controls.Add(this.label2);
			this.gbEdicao.Controls.Add(this.label10);
			this.gbEdicao.Controls.Add(this.btnLimpar);
			this.gbEdicao.Controls.Add(this.label9);
			this.gbEdicao.Controls.Add(this.btnExcluir);
			this.gbEdicao.Controls.Add(this.txtCp);
			this.gbEdicao.Controls.Add(this.txtEndereco);
			this.gbEdicao.Controls.Add(this.label11);
			this.gbEdicao.Controls.Add(this.txtBairro);
			this.gbEdicao.Controls.Add(this.txtRg);
			this.gbEdicao.Controls.Add(this.label8);
			this.gbEdicao.Controls.Add(this.txtCpf);
			this.gbEdicao.Controls.Add(this.label3);
			this.gbEdicao.Controls.Add(this.txtNome);
			this.gbEdicao.Controls.Add(this.cbSexo);
			this.gbEdicao.Controls.Add(this.label4);
			this.gbEdicao.Controls.Add(this.label5);
			this.gbEdicao.Location = new System.Drawing.Point(-8, 58);
			this.gbEdicao.Name = "gbEdicao";
			this.gbEdicao.Size = new System.Drawing.Size(503, 523);
			this.gbEdicao.TabIndex = 26;
			this.gbEdicao.TabStop = false;
			this.gbEdicao.Visible = false;
			// 
			// lblExcluir
			// 
			this.lblExcluir.AutoSize = true;
			this.lblExcluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExcluir.Location = new System.Drawing.Point(336, 500);
			this.lblExcluir.Name = "lblExcluir";
			this.lblExcluir.Size = new System.Drawing.Size(51, 16);
			this.lblExcluir.TabIndex = 28;
			this.lblExcluir.Text = "Excluir";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(222, 500);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 16);
			this.label14.TabIndex = 27;
			this.label14.Text = "Limpar";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(108, 500);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 16);
			this.label13.TabIndex = 26;
			this.label13.Text = "Salvar";
			// 
			// lblEdicao
			// 
			this.lblEdicao.AutoSize = true;
			this.lblEdicao.BackColor = System.Drawing.Color.Transparent;
			this.lblEdicao.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEdicao.Location = new System.Drawing.Point(37, 203);
			this.lblEdicao.Name = "lblEdicao";
			this.lblEdicao.Size = new System.Drawing.Size(405, 58);
			this.lblEdicao.TabIndex = 27;
			this.lblEdicao.Text = "Nem um Aluno Selecionado. \r\nSelecione um aluno para continua";
			this.lblEdicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSelecionar
			// 
			this.btnSelecionar.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSelecionar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSelecionar.Location = new System.Drawing.Point(163, 296);
			this.btnSelecionar.Name = "btnSelecionar";
			this.btnSelecionar.Size = new System.Drawing.Size(119, 30);
			this.btnSelecionar.TabIndex = 28;
			this.btnSelecionar.Text = "Selecionar Aluno";
			this.btnSelecionar.UseVisualStyleBackColor = false;
			this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(491, 24);
			this.menuStrip1.TabIndex = 29;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mtsMenuItem
			// 
			this.mtsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuPrincipal,
            this.tsMenuCadastro,
            this.tsMenuPesquisa,
            this.tsMenuPerfil});
			this.mtsMenuItem.Image = global::ProjetoEscola.Properties.Resources.menu_burger;
			this.mtsMenuItem.Name = "mtsMenuItem";
			this.mtsMenuItem.Size = new System.Drawing.Size(68, 20);
			this.mtsMenuItem.Text = "MENU";
			// 
			// tsMenuPrincipal
			// 
			this.tsMenuPrincipal.Image = global::ProjetoEscola.Properties.Resources.home;
			this.tsMenuPrincipal.Name = "tsMenuPrincipal";
			this.tsMenuPrincipal.Size = new System.Drawing.Size(180, 22);
			this.tsMenuPrincipal.Text = "Menu Principal";
			this.tsMenuPrincipal.Click += new System.EventHandler(this.tsMenuPrincipal_Click);
			// 
			// tsMenuCadastro
			// 
			this.tsMenuCadastro.Image = global::ProjetoEscola.Properties.Resources.users_alt;
			this.tsMenuCadastro.Name = "tsMenuCadastro";
			this.tsMenuCadastro.Size = new System.Drawing.Size(180, 22);
			this.tsMenuCadastro.Text = "Cadastro Aluno";
			this.tsMenuCadastro.Click += new System.EventHandler(this.tsMenuCadastro_Click);
			// 
			// tsMenuPesquisa
			// 
			this.tsMenuPesquisa.Image = global::ProjetoEscola.Properties.Resources.search;
			this.tsMenuPesquisa.Name = "tsMenuPesquisa";
			this.tsMenuPesquisa.Size = new System.Drawing.Size(180, 22);
			this.tsMenuPesquisa.Text = "Pesquisa";
			this.tsMenuPesquisa.Click += new System.EventHandler(this.tsMenuPesquisa_Click);
			// 
			// tsMenuPerfil
			// 
			this.tsMenuPerfil.Image = global::ProjetoEscola.Properties.Resources.user;
			this.tsMenuPerfil.Name = "tsMenuPerfil";
			this.tsMenuPerfil.Size = new System.Drawing.Size(180, 22);
			this.tsMenuPerfil.Text = "Perfil";
			this.tsMenuPerfil.Click += new System.EventHandler(this.tsMenuPerfil_Click);
			// 
			// frmEdicao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.BackgroundImage = global::ProjetoEscola.Properties.Resources.Fundo_escola;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(491, 579);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbEdicao);
			this.Controls.Add(this.btnSelecionar);
			this.Controls.Add(this.lblEdicao);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmEdicao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editar ou Excluir";
			this.Load += new System.EventHandler(this.frmEdicao_Load);
			this.gbEdicao.ResumeLayout(false);
			this.gbEdicao.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.MaskedTextBox txtCp;
		private System.Windows.Forms.ComboBox cbSexo;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.TextBox txtObservacoes;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.MaskedTextBox txtRg;
		private System.Windows.Forms.TextBox txtRegistro;
		private System.Windows.Forms.Label label1;
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
		private System.Windows.Forms.GroupBox gbEdicao;
		private System.Windows.Forms.Label lblExcluir;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblEdicao;
		private System.Windows.Forms.Button btnSelecionar;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mtsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPrincipal;
		private System.Windows.Forms.ToolStripMenuItem tsMenuCadastro;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPesquisa;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPerfil;
	}
}