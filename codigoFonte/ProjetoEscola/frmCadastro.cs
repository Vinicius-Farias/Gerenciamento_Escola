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

namespace ProjetoEscola
{
	public partial class frmCadastro : Form
	{
		
		public frmCadastro()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				int idAluno = 0;
				SalvarAlunoRegraNegocio salvarAluno = new SalvarAlunoRegraNegocio();
				salvarAluno.salvarAluno(idAluno ,txtNome.Text, txtTelefone.Text, cbSexo.SelectedItem.ToString(),
					dtpNascimento.Value.Date, txtEndereco.Text, txtBairro.Text, txtCep.Text, txtObservacoes.Text, 
					txtRg.Text, txtCpf.Text);

				MessageBox.Show("Aluno Salvor com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimparTextBox(this.Controls);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LimparTextBox(Control.ControlCollection controles)
		{
			//Faz um laço para todos os controles passados no parâmetro
			foreach (Control ctrl in controles)
			{
				// Se o controle for um TextBox
				if (ctrl is TextBox)
				{
					((TextBox)(ctrl)).Text = string.Empty;
				}
			}

			dtpNascimento.Value = DateTime.Today;
			txtCpf.Clear();
			txtRg.Clear();
			txtTelefone.Clear();
			txtCep.Clear();
			cbSexo.SelectedIndex = 0;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			LimparTextBox(this.Controls);
		}

		private void tsMenuPrincipal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tsMenuPesquisa_Click(object sender, EventArgs e)
		{
			frmPesquisar pesquisar = new frmPesquisar();
			pesquisar.Show();
			this.Close();
		}

		private void tsMenuEditar_Click(object sender, EventArgs e)
		{
			frmEdicao edicao = new frmEdicao();
			edicao.Show();
			this.Close();
		}

		private void tsMenuPerfil_Click(object sender, EventArgs e)
		{
			frmPerfil perfil = new frmPerfil();
			perfil.Show();
			this.Close();
		}
	}
}
