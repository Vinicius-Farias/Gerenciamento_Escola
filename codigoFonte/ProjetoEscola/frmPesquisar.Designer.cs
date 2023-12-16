namespace ProjetoEscola
{
	partial class frmPesquisar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisar));
			this.dtgPesquisaAluno = new System.Windows.Forms.DataGridView();
			this.ID_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NOME_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONE_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GENERO_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NASCIMENTO_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ENDERECO_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BAIRRO_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CEP_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OBSERVACOES_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RG_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPF_ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbCpf = new System.Windows.Forms.RadioButton();
			this.rbRg = new System.Windows.Forms.RadioButton();
			this.rbNome = new System.Windows.Forms.RadioButton();
			this.txtPesquisar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mtsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuEditar = new System.Windows.Forms.ToolStripMenuItem();
			this.tsMenuPerfil = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaAluno)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgPesquisaAluno
			// 
			this.dtgPesquisaAluno.AllowUserToAddRows = false;
			this.dtgPesquisaAluno.AllowUserToDeleteRows = false;
			this.dtgPesquisaAluno.AllowUserToResizeColumns = false;
			this.dtgPesquisaAluno.AllowUserToResizeRows = false;
			this.dtgPesquisaAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgPesquisaAluno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ALUNO,
            this.NOME_ALUNO,
            this.TELEFONE_ALUNO,
            this.GENERO_ALUNO,
            this.NASCIMENTO_ALUNO,
            this.ENDERECO_ALUNO,
            this.BAIRRO_ALUNO,
            this.CEP_ALUNO,
            this.OBSERVACOES_ALUNO,
            this.RG_ALUNO,
            this.CPF_ALUNO,
            this.btnEditar});
			this.dtgPesquisaAluno.EnableHeadersVisualStyles = false;
			this.dtgPesquisaAluno.Location = new System.Drawing.Point(12, 270);
			this.dtgPesquisaAluno.MultiSelect = false;
			this.dtgPesquisaAluno.Name = "dtgPesquisaAluno";
			this.dtgPesquisaAluno.ReadOnly = true;
			this.dtgPesquisaAluno.RowHeadersVisible = false;
			this.dtgPesquisaAluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgPesquisaAluno.ShowEditingIcon = false;
			this.dtgPesquisaAluno.Size = new System.Drawing.Size(776, 252);
			this.dtgPesquisaAluno.TabIndex = 0;
			this.dtgPesquisaAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPesquisaAluno_CellContentClick);
			// 
			// ID_ALUNO
			// 
			this.ID_ALUNO.DataPropertyName = "ID_ALUNO";
			this.ID_ALUNO.HeaderText = "ID_ALUNO";
			this.ID_ALUNO.Name = "ID_ALUNO";
			this.ID_ALUNO.ReadOnly = true;
			this.ID_ALUNO.Visible = false;
			// 
			// NOME_ALUNO
			// 
			this.NOME_ALUNO.DataPropertyName = "NOME_ALUNO";
			this.NOME_ALUNO.HeaderText = "Nome";
			this.NOME_ALUNO.Name = "NOME_ALUNO";
			this.NOME_ALUNO.ReadOnly = true;
			this.NOME_ALUNO.Width = 170;
			// 
			// TELEFONE_ALUNO
			// 
			this.TELEFONE_ALUNO.DataPropertyName = "TELEFONE_ALUNO";
			this.TELEFONE_ALUNO.HeaderText = "Telefone";
			this.TELEFONE_ALUNO.Name = "TELEFONE_ALUNO";
			this.TELEFONE_ALUNO.ReadOnly = true;
			this.TELEFONE_ALUNO.Width = 80;
			// 
			// GENERO_ALUNO
			// 
			this.GENERO_ALUNO.DataPropertyName = "GENERO_ALUNO";
			this.GENERO_ALUNO.HeaderText = "GENERO_ALUNO";
			this.GENERO_ALUNO.Name = "GENERO_ALUNO";
			this.GENERO_ALUNO.ReadOnly = true;
			this.GENERO_ALUNO.Visible = false;
			// 
			// NASCIMENTO_ALUNO
			// 
			this.NASCIMENTO_ALUNO.DataPropertyName = "NASCIMENTO_ALUNO";
			this.NASCIMENTO_ALUNO.HeaderText = "Data Nascimento";
			this.NASCIMENTO_ALUNO.Name = "NASCIMENTO_ALUNO";
			this.NASCIMENTO_ALUNO.ReadOnly = true;
			this.NASCIMENTO_ALUNO.Width = 120;
			// 
			// ENDERECO_ALUNO
			// 
			this.ENDERECO_ALUNO.DataPropertyName = "ENDERECO_ALUNO";
			this.ENDERECO_ALUNO.HeaderText = "Endereço";
			this.ENDERECO_ALUNO.Name = "ENDERECO_ALUNO";
			this.ENDERECO_ALUNO.ReadOnly = true;
			this.ENDERECO_ALUNO.Width = 170;
			// 
			// BAIRRO_ALUNO
			// 
			this.BAIRRO_ALUNO.DataPropertyName = "BAIRRO_ALUNO";
			this.BAIRRO_ALUNO.HeaderText = "Bairro";
			this.BAIRRO_ALUNO.Name = "BAIRRO_ALUNO";
			this.BAIRRO_ALUNO.ReadOnly = true;
			this.BAIRRO_ALUNO.Width = 110;
			// 
			// CEP_ALUNO
			// 
			this.CEP_ALUNO.DataPropertyName = "CEP_ALUNO";
			this.CEP_ALUNO.HeaderText = "Cep";
			this.CEP_ALUNO.Name = "CEP_ALUNO";
			this.CEP_ALUNO.ReadOnly = true;
			this.CEP_ALUNO.Width = 70;
			// 
			// OBSERVACOES_ALUNO
			// 
			this.OBSERVACOES_ALUNO.DataPropertyName = "OBSERVACOES_ALUNO";
			this.OBSERVACOES_ALUNO.HeaderText = "OBSERVACOES_ALUNO";
			this.OBSERVACOES_ALUNO.Name = "OBSERVACOES_ALUNO";
			this.OBSERVACOES_ALUNO.ReadOnly = true;
			this.OBSERVACOES_ALUNO.Visible = false;
			// 
			// RG_ALUNO
			// 
			this.RG_ALUNO.DataPropertyName = "RG_ALUNO";
			this.RG_ALUNO.HeaderText = "RG_ALUNO";
			this.RG_ALUNO.Name = "RG_ALUNO";
			this.RG_ALUNO.ReadOnly = true;
			this.RG_ALUNO.Visible = false;
			// 
			// CPF_ALUNO
			// 
			this.CPF_ALUNO.DataPropertyName = "CPF_ALUNO";
			this.CPF_ALUNO.HeaderText = "CPF_ALUNO";
			this.CPF_ALUNO.Name = "CPF_ALUNO";
			this.CPF_ALUNO.ReadOnly = true;
			this.CPF_ALUNO.Visible = false;
			// 
			// btnEditar
			// 
			this.btnEditar.HeaderText = "";
			this.btnEditar.Image = global::ProjetoEscola.Properties.Resources.editar;
			this.btnEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ReadOnly = true;
			this.btnEditar.Width = 30;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbCpf);
			this.groupBox1.Controls.Add(this.rbRg);
			this.groupBox1.Controls.Add(this.rbNome);
			this.groupBox1.Controls.Add(this.txtPesquisar);
			this.groupBox1.Location = new System.Drawing.Point(149, 172);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(502, 92);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// rbCpf
			// 
			this.rbCpf.AutoSize = true;
			this.rbCpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCpf.Location = new System.Drawing.Point(325, 65);
			this.rbCpf.Name = "rbCpf";
			this.rbCpf.Size = new System.Drawing.Size(47, 19);
			this.rbCpf.TabIndex = 4;
			this.rbCpf.TabStop = true;
			this.rbCpf.Text = "CPF";
			this.rbCpf.UseVisualStyleBackColor = true;
			// 
			// rbRg
			// 
			this.rbRg.AutoSize = true;
			this.rbRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbRg.Location = new System.Drawing.Point(227, 65);
			this.rbRg.Name = "rbRg";
			this.rbRg.Size = new System.Drawing.Size(41, 19);
			this.rbRg.TabIndex = 3;
			this.rbRg.TabStop = true;
			this.rbRg.Text = "RG";
			this.rbRg.UseVisualStyleBackColor = true;
			// 
			// rbNome
			// 
			this.rbNome.AutoSize = true;
			this.rbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNome.Location = new System.Drawing.Point(118, 65);
			this.rbNome.Name = "rbNome";
			this.rbNome.Size = new System.Drawing.Size(58, 19);
			this.rbNome.TabIndex = 2;
			this.rbNome.TabStop = true;
			this.rbNome.Text = "Nome";
			this.rbNome.UseVisualStyleBackColor = true;
			// 
			// txtPesquisar
			// 
			this.txtPesquisar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisar.Location = new System.Drawing.Point(73, 19);
			this.txtPesquisar.Name = "txtPesquisar";
			this.txtPesquisar.Size = new System.Drawing.Size(362, 21);
			this.txtPesquisar.TabIndex = 1;
			this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(259, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(302, 46);
			this.label1.TabIndex = 3;
			this.label1.Text = "Area de Pesquisa";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 172);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(131, 92);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Atenção";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 42);
			this.label2.TabIndex = 5;
			this.label2.Text = "Selecione um modo\r\nde Pesquisa Ex:\r\nNome, RG ou CPF ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mtsMenuItem
			// 
			this.mtsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuPrincipal,
            this.tsMenuCadastro,
            this.tsMenuEditar,
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
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::ProjetoEscola.Properties.Resources.editar;
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.Width = 30;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::ProjetoEscola.Properties.Resources.fundo_escola2;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(92, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(619, 127);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// frmPesquisar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(800, 534);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dtgPesquisaAluno);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmPesquisar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pesquisa de Aluno";
			this.Load += new System.EventHandler(this.frmPesquisar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgPesquisaAluno)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgPesquisaAluno;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbCpf;
		private System.Windows.Forms.RadioButton rbRg;
		private System.Windows.Forms.RadioButton rbNome;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOME_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn GENERO_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn NASCIMENTO_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CEP_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACOES_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn RG_ALUNO;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPF_ALUNO;
		private System.Windows.Forms.DataGridViewImageColumn btnEditar;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mtsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPrincipal;
		private System.Windows.Forms.ToolStripMenuItem tsMenuCadastro;
		private System.Windows.Forms.ToolStripMenuItem tsMenuEditar;
		private System.Windows.Forms.ToolStripMenuItem tsMenuPerfil;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
	}
}