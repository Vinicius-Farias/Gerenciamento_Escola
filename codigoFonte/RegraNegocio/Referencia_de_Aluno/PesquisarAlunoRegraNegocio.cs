using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;

namespace RegraNegocio
{
	public class PesquisarAlunoRegraNegocio
	{
		PesquisarAluno Pesquisar;

		public DataTable PesquisarNome(string nome)
		{
			try
			{
				Pesquisar = new PesquisarAluno();
				DataTable dadosTabela = new DataTable();
				return dadosTabela = Pesquisar.PesquisaNome(nome);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public DataTable PesquisarRg(string rg)
		{
			try
			{
				Pesquisar = new PesquisarAluno();
				DataTable dadosTabela = new DataTable();
				return dadosTabela = Pesquisar.PesquisaRg(rg);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public DataTable PesquisarCpf(string cpf)
		{
			try
			{
				Pesquisar = new PesquisarAluno();
				DataTable dadosTabela = new DataTable();
				return dadosTabela = Pesquisar.PesquisaCpf(cpf);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
