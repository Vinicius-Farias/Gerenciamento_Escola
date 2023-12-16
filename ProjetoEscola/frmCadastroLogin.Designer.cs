namespace ProjetoEscola
{
	partial class frmCadastroLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroLogin));
			this.txtNomeUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtSenha2 = new System.Windows.Forms.TextBox();
			this.cbNivelUsuario = new System.Windows.Forms.ComboBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.ckbVisualizaSenha = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNomeUsuario
			// 
			this.txtNomeUsuario.Location = new System.Drawing.Point(18, 105);
			this.txtNomeUsuario.Name = "txtNomeUsuario";
			this.txtNomeUsuario.Size = new System.Drawing.Size(231, 20);
			this.txtNomeUsuario.TabIndex = 1;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(18, 199);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(166, 20);
			this.txtSenha.TabIndex = 3;
			// 
			// txtSenha2
			// 
			this.txtSenha2.Location = new System.Drawing.Point(18, 247);
			this.txtSenha2.Name = "txtSenha2";
			this.txtSenha2.PasswordChar = '*';
			this.txtSenha2.Size = new System.Drawing.Size(166, 20);
			this.txtSenha2.TabIndex = 4;
			// 
			// cbNivelUsuario
			// 
			this.cbNivelUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbNivelUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNivelUsuario.FormattingEnabled = true;
			this.cbNivelUsuario.Items.AddRange(new object[] {
            "",
            "Diretor (a)",
            "Vice Diretor (a)",
            "funcionario (a)"});
			this.cbNivelUsuario.Location = new System.Drawing.Point(275, 104);
			this.cbNivelUsuario.Name = "cbNivelUsuario";
			this.cbNivelUsuario.Size = new System.Drawing.Size(121, 21);
			this.cbNivelUsuario.TabIndex = 5;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnSalvar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(174, 330);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 30);
			this.btnSalvar.TabIndex = 7;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// ckbVisualizaSenha
			// 
			this.ckbVisualizaSenha.AutoSize = true;
			this.ckbVisualizaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ckbVisualizaSenha.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbVisualizaSenha.Location = new System.Drawing.Point(18, 282);
			this.ckbVisualizaSenha.Name = "ckbVisualizaSenha";
			this.ckbVisualizaSenha.Size = new System.Drawing.Size(124, 18);
			this.ckbVisualizaSenha.TabIndex = 6;
			this.ckbVisualizaSenha.Text = "Visualiza a Senha ";
			this.ckbVisualizaSenha.UseVisualStyleBackColor = true;
			this.ckbVisualizaSenha.CheckedChanged += new System.EventHandler(this.ckbVisualizaSenha_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 14);
			this.label1.TabIndex = 6;
			this.label1.Text = "Nome de Úsuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Ink Free", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(319, 46);
			this.label2.TabIndex = 7;
			this.label2.Text = "Cadastro de Login";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 14);
			this.label3.TabIndex = 8;
			this.label3.Text = "Senha";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 14);
			this.label4.TabIndex = 9;
			this.label4.Text = "Repita a Senha";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(272, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 14);
			this.label5.TabIndex = 10;
			this.label5.Text = "Nivel de úsuario";
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnLimpar.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(53, 330);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 30);
			this.btnLimpar.TabIndex = 8;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 138);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 14);
			this.label6.TabIndex = 13;
			this.label6.Text = "Email de Recuperação";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(18, 154);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(231, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(289, 330);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 9;
			this.button1.Text = "Excluir ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmCadastroLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			this.BackgroundImage = global::ProjetoEscola.Properties.Resources.Fundo_escola;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(416, 390);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ckbVisualizaSenha);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.cbNivelUsuario);
			this.Controls.Add(this.txtSenha2);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtNomeUsuario);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmCadastroLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Login";
			this.Load += new System.EventHandler(this.frmCadastroLogin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNomeUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.TextBox txtSenha2;
		private System.Windows.Forms.ComboBox cbNivelUsuario;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.CheckBox ckbVisualizaSenha;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button button1;
	}
}