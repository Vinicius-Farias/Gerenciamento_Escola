using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio.Referencia_de_Login.Validacoes_Login;
using RegraNegocio.Referencia_de_Login.CriarLoginPadrao;
using RegraNegocio.Variaves_Globais;

namespace ProjetoEscola
{
	public partial class frmEntraLogin : Form
	{
		public frmEntraLogin()
		{
			InitializeComponent();
			this.TopMost = false;
		}

		private void btnEntrar_Click(object sender, EventArgs e)
		{
			try
			{
				EntradaLogin login = new EntradaLogin();
				if(login.RetornaLogin(txtUsuario.Text, txtSenha.Text) == true )
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Você que mesmo sair do sistema ?", "INFORMAÇÂO", MessageBoxButtons.YesNo, 
				MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.DialogResult = DialogResult.Cancel;
			}
		}

		private void ckbExibirSenha_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbExibirSenha.Checked)
			{
				txtSenha.PasswordChar = '\0';
			}
			else
			{
				txtSenha.PasswordChar = '*';
			}
		}

		private void lblLinkPrepara_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.instagram.com/preparafeiradesantana/?utm_source=ig_web_button_share_sheet&igshid=OGQ5ZDc2ODk2ZA==");
			this.TopMost = false;
		}

		private void lblLinkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmNovaSenha novaSenha = new frmNovaSenha();
			novaSenha.ShowDialog();
		}

		private void CriarLogiPadrao()
		{
			try
			{
				CriarLoginPadrao loginPadrao = new CriarLoginPadrao();
				loginPadrao.LoginPadrao();

				if (UsuarioLogado.LoginPadraoCriado)
				{
					MessageBox.Show("Login do sistema Criador: ( úsuario: admin senha: admin123 )", "SUCESSO", MessageBoxButtons.OK);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmEntraLogin_Load(object sender, EventArgs e)
		{
			CriarLogiPadrao();
		}
	}
}
