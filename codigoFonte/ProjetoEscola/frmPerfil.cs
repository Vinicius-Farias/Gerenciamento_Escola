using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio.Variaves_Globais;
using RegraNegocio.Referencia_de_Login.AlteraLogin;

namespace ProjetoEscola
{
	public partial class frmPerfil : Form
	{
		public frmPerfil()
		{
			InitializeComponent();
		}

		private void frmPerfil_Load(object sender, EventArgs e)
		{
			dadosUsuario();
		}

		private void btnAltera_Click(object sender, EventArgs e)
		{
			try
			{
				AlteraUsuarioRegraNegocio alteraUsuario = new AlteraUsuarioRegraNegocio();

				if(gpbAlteraSenha.Visible == true)
				{
					if (txtSenha.Text == txtSenha2.Text)
					{
						alteraUsuario.AlteraUsuario(txtNomeUsuario.Text, txtEmail.Text, txtSenha.Text);
					}
					else
					{
						MessageBox.Show("As senhas não coencide corrija a senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txtSenha2.Focus();
					}
				}
				else
				{
					alteraUsuario.AlteraUsuario(txtNomeUsuario.Text, txtEmail.Text);
				}

				MessageBox.Show("Úsuario Alterado com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message ,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dadosUsuario()
		{
			txtNomeUsuario.Text = UsuarioLogado.usuario;
			txtEmail.Text = UsuarioLogado.email;
		}

		private void btnAlteraSenha_Click(object sender, EventArgs e)
		{
			gpbAlteraSenha.Visible = true;
		}

		private void btnSim_Click(object sender, EventArgs e)
		{
			gpbAlteraLogin.Visible = true;
		}

		private void ckbExibiSenha_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbExibiSenha.Checked)
			{
				txtSenha.PasswordChar = '\0';
			}
			else
			{
				txtSenha.PasswordChar = '*';
			}
		}
	}
}
