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

namespace ProjetoEscola
{
	public partial class frmExcluirLogin : Form
	{
		ExibirExcluirLogin exibirExcluir;

		public frmExcluirLogin()
		{
			InitializeComponent();
		}

		private void Listar()
		{
			try
			{
				exibirExcluir = new ExibirExcluirLogin();
				dtgPesquisa.DataSource = exibirExcluir.ExibirLogins();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmExcluirLogin_Load(object sender, EventArgs e)
		{
			Listar();
		}

		private void txtPesquisa_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if(rbUsuario.Checked)
				{
					exibirExcluir = new ExibirExcluirLogin();
					dtgPesquisa.DataSource = exibirExcluir.PesquisaUsuarios(txtPesquisa.Text);
				}
				else if (rbEmail.Checked)
				{
					exibirExcluir = new ExibirExcluirLogin();
					dtgPesquisa.DataSource = exibirExcluir.PesquisaEmails(txtPesquisa.Text);
				}

				if (txtPesquisa.Text == "")
					Listar();

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dtgPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if(e.RowIndex >= 0)
				{
					if (dtgPesquisa.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Você deseja Excluir esse Cadastro?",
						"AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
					{
						exibirExcluir = new ExibirExcluirLogin();
						exibirExcluir.ExcluirLogins(Convert.ToInt32(dtgPesquisa.Rows[e.RowIndex].Cells["ID_LOGIN"].Value.ToString()));

						MessageBox.Show("Login Excluído com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtPesquisa.Clear();
						Listar();
					}
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmExcluirLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmCadastroLogin cadastroLogin = new frmCadastroLogin();
			cadastroLogin.Show();
		}
	}
}
