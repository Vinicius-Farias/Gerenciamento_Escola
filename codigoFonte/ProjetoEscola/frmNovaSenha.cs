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
using RegraNegocio.Referencia_de_Login;
using RegraNegocio.Variaves_Globais;

namespace ProjetoEscola
{
	public partial class frmNovaSenha : Form
	{
		public frmNovaSenha()
		{
			InitializeComponent();
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEnviar_Click(object sender, EventArgs e)
		{
			try
			{
				ConfirmaEmailLogin confirmaEmail = new ConfirmaEmailLogin();
				confirmaEmail.ConfirmaEmail(txtEmail.Text);
				gpbVerificaEmail.Visible = false;
				gpbCodigo.Visible = true;
				lblNomeUsuario.Text = "Òla "+ UsuarioLogado.usuario;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEnviarCodigo_Click(object sender, EventArgs e)
		{
			if(UsuarioLogado.codigo == txtCodigo.Text)
			{
				gpbCodigo.Visible = false;
				gpbNovaSenha.Visible = true;
			}
			else
			{
				MessageBox.Show("Código invalido Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				ConfirmaEmailLogin confirmaEmail = new ConfirmaEmailLogin();
				confirmaEmail.ConfirmaEmail(UsuarioLogado.email);
				MessageBox.Show("Código reenviado tente novamente digita o código", "SUCESSO", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)	;
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				if(txtSenha1.Text == txtSenha2.Text)
				{
					AlteraSenhaLogin alteraSenha = new AlteraSenhaLogin();
					alteraSenha.AlteraSenha(txtSenha1.Text);
					MessageBox.Show("Senha redefinida com sucesso", "SUCESSO", MessageBoxButtons.OK);
					this.Close();
				}
				else
				{
					MessageBox.Show("As senhas não são iguais verifique a senha digitada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ckbExibirSenha_CheckedChanged(object sender, EventArgs e)
		{
			if (ckbExibirSenha.Checked)
			{
				txtSenha1.PasswordChar = '\0';
				txtSenha2.PasswordChar = '\0';
			}
			else
			{
				txtSenha1.PasswordChar = '*';
				txtSenha2.PasswordChar = '*';
			}
		}
	}
}
