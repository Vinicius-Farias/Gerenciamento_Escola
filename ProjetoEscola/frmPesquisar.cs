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
	public partial class frmPesquisar : Form
	{
		frmEdicao edicao;
		PesquisarAlunoRegraNegocio PesquisarAluno;

		public frmPesquisar()
		{
			InitializeComponent();
		}
		
		private void Listar()
		{
			try
			{
				Principal listarAluno = new Principal();
				dtgPesquisaAluno.DataSource = listarAluno.ListarAlunos();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmPesquisar_Load(object sender, EventArgs e)
		{
			Listar();
		}

		private void txtPesquisar_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (rbNome.Checked)
				{
					PesquisarAluno = new PesquisarAlunoRegraNegocio();
					dtgPesquisaAluno.DataSource = PesquisarAluno.PesquisarNome(txtPesquisar.Text);
				}
				if (rbRg.Checked)
				{
					PesquisarAluno = new PesquisarAlunoRegraNegocio();
					dtgPesquisaAluno.DataSource = PesquisarAluno.PesquisarRg(txtPesquisar.Text);
				}
				if (rbCpf.Checked)
				{
					PesquisarAluno = new PesquisarAlunoRegraNegocio();
					dtgPesquisaAluno.DataSource = PesquisarAluno.PesquisarCpf(txtPesquisar.Text);
				}

				if (txtPesquisar.Text == "")
				{
					Listar();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void dtgPesquisaAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0)
			{
				if (dtgPesquisaAluno.Columns[e.ColumnIndex].Name == "btnEditar" && MessageBox.Show("Você deseja Fazer alteração nesse cadastro?",
					"Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					edicao = new frmEdicao();
					edicao.ReceberPesquisa(
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["ID_ALUNO"].Value.ToString(), 
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["NOME_ALUNO"].Value.ToString(), 
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["TELEFONE_ALUNO"].Value.ToString(), 
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["GENERO_ALUNO"].Value.ToString(), 
						DateTime.Parse(dtgPesquisaAluno.Rows[e.RowIndex].Cells["NASCIMENTO_ALUNO"].Value.ToString()), 
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["ENDERECO_ALUNO"].Value.ToString(), 
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["BAIRRO_ALUNO"].Value.ToString(), 
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["CEP_ALUNO"].Value.ToString(),
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["OBSERVACOES_ALUNO"].Value.ToString(),
						dtgPesquisaAluno.Rows[e.RowIndex].Cells["RG_ALUNO"].Value.ToString(),
						 dtgPesquisaAluno.Rows[e.RowIndex].Cells["CPF_ALUNO"].Value.ToString()
						 );

					edicao.Show();
					this.Close();
					
				}
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
