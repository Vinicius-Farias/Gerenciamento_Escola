using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using RegraNegocio.Variaves_Globais;
using AcessoDados.Referencias_de_Login.Pesquisas_Validacoes;
using RegraNegocio.Referencia_de_Login.Validacoes_Login;

namespace RegraNegocio.Referencia_de_Login.CriarLoginPadrao
{
	public class CriarLoginPadrao
	{
		public void LoginPadrao()
		{
			try
			{
				PesquisaValidacao pesquisaValidacao = new PesquisaValidacao();
				DataTable dadosTabela = new DataTable();
				SalvarLogin salvarLogin = new SalvarLogin();

				dadosTabela = pesquisaValidacao.PesquisaUsuario("admin");

				if (dadosTabela.Rows.Count > 0)
				{
					UsuarioLogado.LoginPadraoCriado = false;
				}
				else
				{
					salvarLogin.SalvarLogins("admin", CriptografiaSenha.GerarHashSenha("admin123"), "Diretor (a)", "admin123@gmail.com");
					UsuarioLogado.LoginPadraoCriado = true;
				}
				
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
