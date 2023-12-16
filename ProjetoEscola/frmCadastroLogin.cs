using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio.Referencia_de_Login;
using RegraNegocio.Variaves_Globais;

namespace ProjetoEscola
{
	public partial class frmCadastroLogin : Form
	{
		public frmCadastroLogin()
		{
			InitializeComponent();
		}

		private void frmCadastroLogin_Load(object sender, EventArgs e)
		{
		
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{

				if (txtSenha.Text == txtSenha2.Text)
				{
					SalvarLoginRegraNegocio salvar = new SalvarLoginRegraNegocio();
					salvar.SalvarLogin(txtNomeUsuario.Text, txtSenha.Text, cbNivelUsuario.SelectedItem.ToString(), txtEmail.Text);

					MessageBox.Show("Login Cadastrado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Limpar();
				}
				else
				{
					txtSenha.Focus();
					throw new Exception("As senhas não são iguais ser certifique-se que os dois campos estão iguais");
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ckbVisualizaSenha_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbVisualizaSenha.Checked)
			{
				txtSenha.PasswordChar = '\0';
				txtSenha2.PasswordChar = '\0';
			}
			else
			{
				txtSenha.PasswordChar = '*';
				txtSenha2.PasswordChar = '*';
			}
		}

		private void Limpar()
		{
			txtNomeUsuario.Clear();
			txtEmail.Clear();
			txtSenha.Clear();
			txtSenha2.Clear();
			cbNivelUsuario.SelectedIndex = 0;
			ckbVisualizaSenha.Checked = false;
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			Limpar();
		}

		private void button1_Click(object sender, EventArgs e)
		{
				frmExcluirLogin excluirLogin = new frmExcluirLogin();
				excluirLogin.Show();
				this.Close();
		}	
	}
}
