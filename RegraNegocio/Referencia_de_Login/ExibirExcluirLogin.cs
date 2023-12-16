using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.Referencias_de_Login;
using AcessoDados.Referencias_de_Login.Pesquisas_Validacoes;

namespace RegraNegocio.Referencia_de_Login
{
	public class ExibirExcluirLogin
	{
		PesquisarLogin exibir;
		
		public DataTable ExibirLogins()
		{
			try
			{
				DataTable dadosTabela = new DataTable();
				exibir = new PesquisarLogin();
				return dadosTabela = exibir.ListaLogins();
				
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public DataTable PesquisaUsuarios(string usuario)
		{
			try
			{
				DataTable dadosTabela = new DataTable();
				exibir = new PesquisarLogin();
				return dadosTabela = exibir.PesquisaUsuario(usuario);

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public DataTable PesquisaEmails(string email)
		{
			try
			{
				DataTable dadosTabela = new DataTable();
				exibir = new PesquisarLogin();
				return dadosTabela = exibir.PesquisaEmail(email);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void ExcluirLogins(int idLogin)
		{
			try
			{
				ExcluirLogin excluirLogin = new ExcluirLogin();
				excluirLogin.ExcluirLogins(idLogin);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
