using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using RegraNegocio.Referencia_de_Login.Validacoes_Login;

namespace RegraNegocio.Referencia_de_Login
{
	public class SalvarLoginRegraNegocio
	{
		private readonly SalvarLogin Salvar = new SalvarLogin();
		private readonly ValidacoesLogin validacoes = new ValidacoesLogin();

		private string senhaCript;
			
		public void SalvarLogin(string usuario, string senha, string nivel, string email)
		{
			try
			{
				senhaCript = CriptografiaSenha.GerarHashSenha(senha);

				validacoes.ValidaCampos(usuario, senhaCript, nivel, email);

				Salvar.SalvarLogins(usuario, senhaCript, nivel, email);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
