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
	public partial class frmSeleciona : Form
	{
		PesquisarAlunoRegraNegocio PesquisarAluno;
		frmEdicao edicao;

		public frmSeleciona()
		{
			InitializeComponent();
		}

		private void frmSeleciona_Load(object sender, EventArgs e)
		{
			Listar();
		}

		private void Listar()
		{
			try
			{
				Principal retornaAlunos = new Principal();
				dtgSelecionaAlunos.DataSource = retornaAlunos.ListarAlunos();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (rbNome.Checked)
				{
					PesquisarAluno = new PesquisarAlunoRegraNegocio();
					dtgSelecionaAlunos.DataSource = PesquisarAluno.PesquisarNome(txtPesquisa.Text);
				}
				if (rbRg.Checked)
				{
					PesquisarAluno = new PesquisarAlunoRegraNegocio();
					dtgSelecionaAlunos.DataSource = PesquisarAluno.PesquisarRg(txtPesquisa.Text);
				}
				if (rbCpf.Checked)
				{
					PesquisarAluno = new PesquisarAlunoRegraNegocio();
					dtgSelecionaAlunos.DataSource = PesquisarAluno.PesquisarCpf(txtPesquisa.Text);
				}

				if(txtPesquisa.Text == "")
				{
					Listar();
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dtgSelecionaAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0)
				{
					
					if (dtgSelecionaAlunos.Columns[e.ColumnIndex].Name == "btnEditar" && MessageBox.Show("Você deseja Fazer alteração nesse cadastro?",
							"Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						edicao = new frmEdicao();
						edicao.ReceberPesquisa(
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["ID_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["NOME_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["TELEFONE_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["GENERO_ALUNO"].Value.ToString(),
							DateTime.Parse(dtgSelecionaAlunos.Rows[e.RowIndex].Cells["NASCIMENTO_ALUNO"].Value.ToString()),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["ENDERECO_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["BAIRRO_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["CEP_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["OBSERVACOES_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["RG_ALUNO"].Value.ToString(),
							dtgSelecionaAlunos.Rows[e.RowIndex].Cells["CPF_ALUNO"].Value.ToString()
						);

						edicao.Show();
						this.Close();
					}
					else if (dtgSelecionaAlunos.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Você deseja Excluir esse Cadastro?",
							"AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						if (UsuarioLogado.nivel == "funcionario (a)")
						{
							MessageBox.Show("Seu nivel de Ùsuario não permiti acesso a essa área", "ATENÇÂO", MessageBoxButtons.OK);
						}
						else
						{
							ExcluirAlunoRegraNegocio excluirAluno = new ExcluirAlunoRegraNegocio();
							excluirAluno.ExcluiAluno(Convert.ToInt32(dtgSelecionaAlunos.Rows[e.RowIndex].Cells["ID_ALUNO"].Value.ToString()));

							MessageBox.Show("Cadastro Excluido com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
							txtPesquisa.Clear();
							Listar();
						}
					}
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


	}
}
