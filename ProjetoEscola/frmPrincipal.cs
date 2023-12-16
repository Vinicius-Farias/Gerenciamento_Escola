using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocio;
using RegraNegocio.Variaves_Globais;

namespace ProjetoEscola
{
	public partial class frmPrincipal : Form
	{

		public frmPrincipal()
		{
			InitializeComponent();
		}
		
		private void btnCadastro_Click(object sender, EventArgs e)
		{
			frmCadastro cadastro = new frmCadastro();
			cadastro.Show();
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{
			frmPesquisar novaPesquisa = new frmPesquisar();
			novaPesquisa.Show();
		}

		private void btnEditarCadastro_Click(object sender, EventArgs e)
		{
			frmEdicao novaEdicao = new frmEdicao();
			novaEdicao.Show();
		}

		private void frmPrincipal_Load(object sender, EventArgs e)
		{
			this.TopMost = false;
			NivelAcesso();
			Conexao();
		}

		private void btnAdicionaLogin_Click(object sender, EventArgs e)
		{
			frmCadastroLogin novoLogin = new frmCadastroLogin();
			novoLogin.Show();
		}

		private void NivelAcesso()
		{
			switch (UsuarioLogado.nivel)
			{
				case "funcionario (a)":
					btnAdicionaLogin.Enabled = false;
					lblLogin.Text = "Bloqueado";
					break;
				case "Vice Diretor (a)":
					btnAdicionaLogin.Enabled = false;
					lblLogin.Text = "Bloqueado";
					break;
				default:
					btnAdicionaLogin.Enabled = true;
					lblLogin.Text = "Novo Login";
					break;
			}
		}

		private void Conexao()
		{
			
			try
			{
				Principal principal = new Principal();
				principal.testandoConexao();
				lblVerificaConexao.Text = "Conectado";
				lblNivel.Text = $"Nivel de Login: {UsuarioLogado.nivel}";
				
			}
			catch (Exception ex)
			{
				lblVerificaConexao.Text = ex.Message;
			}
		}

		private void btnPerfil_Click(object sender, EventArgs e)
		{
			frmPerfil frmPerfil = new frmPerfil();
			frmPerfil.ShowDialog();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Você que mesmo sai do aplicativo ?", "AVISO", MessageBoxButtons.YesNo) == DialogResult.Yes)
			Application.Exit();
		}
	}
}
