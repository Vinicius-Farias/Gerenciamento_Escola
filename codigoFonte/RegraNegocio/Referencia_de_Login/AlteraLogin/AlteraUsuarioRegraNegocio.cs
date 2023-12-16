using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegraNegocio.Variaves_Globais;
using AcessoDados.Referencias_de_Login.AlteraLogin;
using RegraNegocio.Referencia_de_Login.Validacoes_Login;
using AcessoDados.Referencias_de_Login;

namespace RegraNegocio.Referencia_de_Login.AlteraLogin
{
	public class AlteraUsuarioRegraNegocio
	{
		private readonly ValidaAlteraLogin valida = new ValidaAlteraLogin();
		private readonly AlteraUsuarioLogin AlteraNUsuario = new AlteraUsuarioLogin();
		private readonly AlteraSenhasLogin AlteraSenha = new AlteraSenhasLogin();
		private readonly AlteraEmailLogin AlteraEmail = new AlteraEmailLogin();

		private string senhaCript;

		public void AlteraUsuario(string usuario, string email)
		{
			try
			{
				valida.ValidaAlteracao(usuario, email);

				AlteraNUsuario.AlteraUsuario(usuario, Convert.ToInt32(UsuarioLogado.idUsuario));
				AlteraEmail.AlteraEmail(email, Convert.ToInt32(UsuarioLogado.idUsuario));

				UsuarioLogado.usuario = usuario;
				UsuarioLogado.email = email;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}

		public void AlteraUsuario(string usuario, string email, string senha)
		{
			try
			{
				senhaCript = CriptografiaSenha.GerarHashSenha(senha);

				valida.ValidaAlteracao(usuario, email, senhaCript);

				AlteraNUsuario.AlteraUsuario(usuario, Convert.ToInt32(UsuarioLogado.idUsuario));
				AlteraEmail.AlteraEmail(email, Convert.ToInt32(UsuarioLogado.idUsuario));
				AlteraSenha.AlteraSenha(Convert.ToInt32(UsuarioLogado.idUsuario), senhaCript);

				UsuarioLogado.usuario = usuario;
				UsuarioLogado.email = email;

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
