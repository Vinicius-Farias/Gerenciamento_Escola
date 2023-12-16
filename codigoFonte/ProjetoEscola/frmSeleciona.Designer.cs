namespace ProjetoEscola
{
	partial class frmSeleciona
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleciona));
			this.label1 = new System.Windows.Forms.Label();
			this.rbNome = new System.Windows.Forms.RadioButton();
			this.rbRg = new System.Windows.Forms.RadioButton();
			this.rbCpf = new System.Windows.Forms.RadioButton();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.dtgSelecionaAlunos = new System.Windows.Forms.DataGridView();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
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
			this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaAlunos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(83, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Selecione um Aluno";
			// 
			// rbNome
			// 
			this.rbNome.AutoSize = true;
			this.rbNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbNome.Location = new System.Drawing.Point(73, 142);
			this.rbNome.Name = "rbNome";
			this.rbNome.Size = new System.Drawing.Size(58, 19);
			this.rbNome.TabIndex = 1;
			this.rbNome.TabStop = true;
			this.rbNome.Text = "Nome";
			this.rbNome.UseVisualStyleBackColor = true;
			// 
			// rbRg
			// 
			this.rbRg.AutoSize = true;
			this.rbRg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbRg.Location = new System.Drawing.Point(187, 142);
			this.rbRg.Name = "rbRg";
			this.rbRg.Size = new System.Drawing.Size(41, 19);
			this.rbRg.TabIndex = 2;
			this.rbRg.TabStop = true;
			this.rbRg.Text = "RG";
			this.rbRg.UseVisualStyleBackColor = true;
			// 
			// rbCpf
			// 
			this.rbCpf.AutoSize = true;
			this.rbCpf.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbCpf.Location = new System.Drawing.Point(287, 142);
			this.rbCpf.Name = "rbCpf";
			this.rbCpf.Size = new System.Drawing.Size(47, 19);
			this.rbCpf.TabIndex = 3;
			this.rbCpf.TabStop = true;
			this.rbCpf.Text = "CPF";
			this.rbCpf.UseVisualStyleBackColor = true;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisa.Location = new System.Drawing.Point(55, 101);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(306, 21);
			this.txtPesquisa.TabIndex = 4;
			this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
			// 
			// dtgSelecionaAlunos
			// 
			this.dtgSelecionaAlunos.AllowUserToAddRows = false;
			this.dtgSelecionaAlunos.AllowUserToDeleteRows = false;
			this.dtgSelecionaAlunos.AllowUserToResizeColumns = false;
			this.dtgSelecionaAlunos.AllowUserToResizeRows = false;
			this.dtgSelecionaAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgSelecionaAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.btnEditar,
            this.btnExcluir});
			this.dtgSelecionaAlunos.Location = new System.Drawing.Point(2, 209);
			this.dtgSelecionaAlunos.MultiSelect = false;
			this.dtgSelecionaAlunos.Name = "dtgSelecionaAlunos";
			this.dtgSelecionaAlunos.ReadOnly = true;
			this.dtgSelecionaAlunos.RowHeadersVisible = false;
			this.dtgSelecionaAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgSelecionaAlunos.Size = new System.Drawing.Size(426, 263);
			this.dtgSelecionaAlunos.TabIndex = 5;
			this.dtgSelecionaAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSelecionaAlunos_CellContentClick);
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.HeaderText = "";
			this.dataGridViewImageColumn1.Image = global::ProjetoEscola.Properties.Resources.editar;
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewImageColumn1.Visible = false;
			this.dataGridViewImageColumn1.Width = 40;
			// 
			// dataGridViewImageColumn2
			// 
			this.dataGridViewImageColumn2.HeaderText = "";
			this.dataGridViewImageColumn2.Image = global::ProjetoEscola.Properties.Resources.excluir2;
			this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
			this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
			this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewImageColumn2.Width = 40;
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
			this.NOME_ALUNO.Width = 130;
			// 
			// TELEFONE_ALUNO
			// 
			this.TELEFONE_ALUNO.DataPropertyName = "TELEFONE_ALUNO";
			this.TELEFONE_ALUNO.HeaderText = "TELEFONE_ALUNO";
			this.TELEFONE_ALUNO.Name = "TELEFONE_ALUNO";
			this.TELEFONE_ALUNO.ReadOnly = true;
			this.TELEFONE_ALUNO.Visible = false;
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
			this.NASCIMENTO_ALUNO.HeaderText = "NASCIMENTO_ALUNO";
			this.NASCIMENTO_ALUNO.Name = "NASCIMENTO_ALUNO";
			this.NASCIMENTO_ALUNO.ReadOnly = true;
			this.NASCIMENTO_ALUNO.Visible = false;
			// 
			// ENDERECO_ALUNO
			// 
			this.ENDERECO_ALUNO.DataPropertyName = "ENDERECO_ALUNO";
			this.ENDERECO_ALUNO.HeaderText = "ENDERECO_ALUNO";
			this.ENDERECO_ALUNO.Name = "ENDERECO_ALUNO";
			this.ENDERECO_ALUNO.ReadOnly = true;
			this.ENDERECO_ALUNO.Visible = false;
			// 
			// BAIRRO_ALUNO
			// 
			this.BAIRRO_ALUNO.DataPropertyName = "BAIRRO_ALUNO";
			this.BAIRRO_ALUNO.HeaderText = "BAIRRO_ALUNO";
			this.BAIRRO_ALUNO.Name = "BAIRRO_ALUNO";
			this.BAIRRO_ALUNO.ReadOnly = true;
			this.BAIRRO_ALUNO.Visible = false;
			// 
			// CEP_ALUNO
			// 
			this.CEP_ALUNO.DataPropertyName = "CEP_ALUNO";
			this.CEP_ALUNO.HeaderText = "CEP_ALUNO";
			this.CEP_ALUNO.Name = "CEP_ALUNO";
			this.CEP_ALUNO.ReadOnly = true;
			this.CEP_ALUNO.Visible = false;
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
			this.RG_ALUNO.HeaderText = "RG";
			this.RG_ALUNO.Name = "RG_ALUNO";
			this.RG_ALUNO.ReadOnly = true;
			this.RG_ALUNO.Width = 110;
			// 
			// CPF_ALUNO
			// 
			this.CPF_ALUNO.DataPropertyName = "CPF_ALUNO";
			this.CPF_ALUNO.HeaderText = "CPF";
			this.CPF_ALUNO.Name = "CPF_ALUNO";
			this.CPF_ALUNO.ReadOnly = true;
			this.CPF_ALUNO.Width = 110;
			// 
			// btnEditar
			// 
			this.btnEditar.HeaderText = "";
			this.btnEditar.Image = global::ProjetoEscola.Properties.Resources.editar;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.ReadOnly = true;
			this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.btnEditar.Width = 30;
			// 
			// btnExcluir
			// 
			this.btnExcluir.HeaderText = "";
			this.btnExcluir.Image = global::ProjetoEscola.Properties.Resources.excluir2;
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.ReadOnly = true;
			this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.btnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.btnExcluir.Width = 30;
			// 
			// frmSeleciona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.ClientSize = new System.Drawing.Size(428, 473);
			this.Controls.Add(this.dtgSelecionaAlunos);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.rbCpf);
			this.Controls.Add(this.rbRg);
			this.Controls.Add(this.rbNome);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmSeleciona";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Selecionar Aluno";
			this.Load += new System.EventHandler(this.frmSeleciona_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgSelecionaAlunos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbNome;
		private System.Windows.Forms.RadioButton rbRg;
		private System.Windows.Forms.RadioButton rbCpf;
		private System.Windows.Forms.TextBox txtPesquisa;
		private System.Windows.Forms.DataGridView dtgSelecionaAlunos;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
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
		private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
	}
}