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
	public partial class frmEdicao : Form
	{
		private DateTime nascimento;
		private string idAluno, nome, telefone, sexo, endereco, bairro, cep, observacoes, rg, cpf;

		public frmEdicao()
		{
			InitializeComponent();
		}

		public void ReceberPesquisa(string idAluno, string nome, string telefone, string sexo, DateTime nascimento, string endereco, string bairro,
			string cep, string observacoes, string rg, string cpf)
		{
			this.idAluno = idAluno;
			this.nome = nome;
			this.telefone = telefone;
			this.sexo = sexo;
			this.nascimento = nascimento;
			this.endereco = endereco;
			this.bairro = bairro;
			this.cep = cep;
			this.observacoes = observacoes;
			this.rg = rg;
			this.cpf = cpf;
		}

		private void frmEdicao_Load(object sender, EventArgs e)
		{
			ValidarAlteracao();
			NivelAcesso();
		}

		private void btnSelecionar_Click(object sender, EventArgs e)
		{
			frmSeleciona FrmSeleciona = new frmSeleciona();
			FrmSeleciona.Show();
			this.Close();
		}

		private void tsMenuPerfil_Click(object sender, EventArgs e)
		{
			frmPerfil perfil = new frmPerfil();
			perfil.Show();
			this.Close();
		}

		private void ValidarAlteracao()
		{
			if(Convert.ToInt32(idAluno) > 0)
			{
				gbEdicao.Visible = true;
				lblEdicao.Visible = false;
				btnSelecionar.Visible = false;

				txtRegistro.Text = idAluno;
				txtNome.Text = nome;
				txtTelefone.Text = telefone;
				dtpNascimento.Value = nascimento;
				txtEndereco.Text = endereco;
				txtBairro.Text = bairro;
				txtCp.Text = cep;
				txtObservacoes.Text = observacoes;
				txtRg.Text = rg;
				txtCpf.Text = cpf;

				switch (sexo)
				{
					case "Masculino":
						cbSexo.SelectedIndex = 1;
						break;
					case "Feminino":
						cbSexo.SelectedIndex = 2;
						break;
					case "Outros":
						cbSexo.SelectedIndex = 3;
						break;
				}
			}
			else
			{
				gbEdicao.Visible = false;
				lblEdicao.Visible = true;
				btnSelecionar.Visible = true;
			}
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			try
			{
				AlteraAlunoRegraNegocio alteraAluno = new AlteraAlunoRegraNegocio();
				alteraAluno.AlteraCadastroAluno(
					Convert.ToInt32(txtRegistro.Text), txtNome.Text, txtTelefone.Text, cbSexo.SelectedItem.ToString(), dtpNascimento.Value.Date, 
					txtEndereco.Text, txtBairro.Text, txtCp.Text, txtObservacoes.Text, txtRg.Text, txtCpf.Text);

				MessageBox.Show("Aluno Alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				LimparTextBox(this.Controls);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			LimparTextBox(this.Controls);
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Você deseja Excluir esse Cadastro ?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					ExcluirAlunoRegraNegocio excluirAluno = new ExcluirAlunoRegraNegocio();
					excluirAluno.ExcluiAluno(Convert.ToInt32(txtRegistro.Text));

					MessageBox.Show("Cadastro Excluido com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LimparTextBox(this.Controls);
				}
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

			gbEdicao.Visible = false;
			lblEdicao.Visible = true;
			btnSelecionar.Visible = true;

			dtpNascimento.Value = DateTime.Today;
			txtCpf.Clear();
			txtRg.Clear();
			txtTelefone.Clear();
			txtCp.Clear();
			cbSexo.SelectedIndex = 0;

		}

		private void NivelAcesso()
		{
			if (UsuarioLogado.nivel == "funcionario (a)")
			{
				btnExcluir.Enabled = false;
				lblExcluir.Text = "Bloqueado";
				lblExcluir.Location = new Point(323, 491);
			}
			else
			{
				btnExcluir.Enabled = true;
				lblExcluir.Text = "Excluir";
				lblExcluir.Location = new Point(336, 491);
			}
		}

		private void tsMenuPrincipal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void tsMenuCadastro_Click(object sender, EventArgs e)
		{
			frmCadastro cadastro = new frmCadastro();
			cadastro.Show();
			this.Close();
		}

		private void tsMenuPesquisa_Click(object sender, EventArgs e)
		{
			frmPesquisar pesquisar = new frmPesquisar();
			pesquisar.Show();
			this.Close();
		}

	}
}
