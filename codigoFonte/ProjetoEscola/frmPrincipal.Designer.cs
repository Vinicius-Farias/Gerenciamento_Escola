namespace ProjetoEscola
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.label1 = new System.Windows.Forms.Label();
			this.btnCadastro = new System.Windows.Forms.Button();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblVerificaConexao = new System.Windows.Forms.Label();
			this.btnEditarCadastro = new System.Windows.Forms.Button();
			this.btnAdicionaLogin = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblNivel = new System.Windows.Forms.Label();
			this.btnPerfil = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(247, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "BEM VINDO";
			// 
			// btnCadastro
			// 
			this.btnCadastro.BackgroundImage = global::ProjetoEscola.Properties.Resources.adiciona;
			this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnCadastro.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastro.ForeColor = System.Drawing.Color.Black;
			this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCadastro.Location = new System.Drawing.Point(47, 147);
			this.btnCadastro.Name = "btnCadastro";
			this.btnCadastro.Size = new System.Drawing.Size(98, 74);
			this.btnCadastro.TabIndex = 1;
			this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCadastro.UseVisualStyleBackColor = true;
			this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.BackgroundImage = global::ProjetoEscola.Properties.Resources.lupar;
			this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnPesquisar.Location = new System.Drawing.Point(220, 147);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(98, 74);
			this.btnPesquisar.TabIndex = 2;
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 224);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cadastro de Aluno";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(218, 224);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Pesquisar Aluno";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(390, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Editar ou Excluir ";
			// 
			// lblVerificaConexao
			// 
			this.lblVerificaConexao.AutoSize = true;
			this.lblVerificaConexao.Location = new System.Drawing.Point(2, 359);
			this.lblVerificaConexao.Name = "lblVerificaConexao";
			this.lblVerificaConexao.Size = new System.Drawing.Size(0, 13);
			this.lblVerificaConexao.TabIndex = 7;
			// 
			// btnEditarCadastro
			// 
			this.btnEditarCadastro.BackColor = System.Drawing.Color.White;
			this.btnEditarCadastro.BackgroundImage = global::ProjetoEscola.Properties.Resources.edit_validated_40458;
			this.btnEditarCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEditarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditarCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnEditarCadastro.Location = new System.Drawing.Point(393, 146);
			this.btnEditarCadastro.Name = "btnEditarCadastro";
			this.btnEditarCadastro.Size = new System.Drawing.Size(98, 74);
			this.btnEditarCadastro.TabIndex = 5;
			this.btnEditarCadastro.UseVisualStyleBackColor = false;
			this.btnEditarCadastro.Click += new System.EventHandler(this.btnEditarCadastro_Click);
			// 
			// btnAdicionaLogin
			// 
			this.btnAdicionaLogin.BackColor = System.Drawing.Color.White;
			this.btnAdicionaLogin.BackgroundImage = global::ProjetoEscola.Properties.Resources.adiciona_login;
			this.btnAdicionaLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAdicionaLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionaLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnAdicionaLogin.Location = new System.Drawing.Point(566, 146);
			this.btnAdicionaLogin.Name = "btnAdicionaLogin";
			this.btnAdicionaLogin.Size = new System.Drawing.Size(98, 74);
			this.btnAdicionaLogin.TabIndex = 8;
			this.btnAdicionaLogin.UseVisualStyleBackColor = false;
			this.btnAdicionaLogin.Click += new System.EventHandler(this.btnAdicionaLogin_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(765, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Novo Login";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.Location = new System.Drawing.Point(582, 223);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(67, 15);
			this.lblLogin.TabIndex = 10;
			this.lblLogin.Text = "Bloqueado";
			// 
			// lblNivel
			// 
			this.lblNivel.AutoSize = true;
			this.lblNivel.Location = new System.Drawing.Point(120, 360);
			this.lblNivel.Name = "lblNivel";
			this.lblNivel.Size = new System.Drawing.Size(0, 13);
			this.lblNivel.TabIndex = 11;
			// 
			// btnPerfil
			// 
			this.btnPerfil.BackColor = System.Drawing.Color.Ivory;
			this.btnPerfil.BackgroundImage = global::ProjetoEscola.Properties.Resources.user;
			this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPerfil.Location = new System.Drawing.Point(4, 2);
			this.btnPerfil.Name = "btnPerfil";
			this.btnPerfil.Size = new System.Drawing.Size(48, 41);
			this.btnPerfil.TabIndex = 12;
			this.btnPerfil.UseVisualStyleBackColor = false;
			this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 44);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Perfil";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Ivory;
			this.button1.BackgroundImage = global::ProjetoEscola.Properties.Resources.excluir2;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(72, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 41);
			this.button1.TabIndex = 14;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(58, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "Desconectar";
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.BackgroundImage = global::ProjetoEscola.Properties.Resources.Fundo_escola;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(724, 374);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnPerfil);
			this.Controls.Add(this.lblNivel);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnAdicionaLogin);
			this.Controls.Add(this.lblVerificaConexao);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnEditarCadastro);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.btnCadastro);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Painel Principal";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCadastro;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblVerificaConexao;
		private System.Windows.Forms.Button btnEditarCadastro;
		private System.Windows.Forms.Button btnAdicionaLogin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.Button btnPerfil;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
	}
}

