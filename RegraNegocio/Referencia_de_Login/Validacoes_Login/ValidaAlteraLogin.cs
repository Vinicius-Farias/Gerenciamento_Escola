using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegraNegocio.Variaves_Globais;
using AcessoDados.Referencias_de_Login.Pesquisas_Validacoes;
using System.Data;

namespace RegraNegocio.Referencia_de_Login.Validacoes_Login
{
	internal class ValidaAlteraLogin
	{
		DataTable dadosTabela;
		RetornaUsuarioLogin RetornaUsuario;
		private readonly ValidacoesLogin validacoes = new ValidacoesLogin();

		internal void ValidaAlteracao(string usuario, string email)
		{
			try
			{
				if (usuario.Trim().Length == 0)
					throw new Exception("O Campo Nome Úsuario não pode ser vazio!");

				if (email.Trim().Length == 0)
					throw new Exception("O Campo Email não pode ser vazio!");

				RetornaUsuario = new RetornaUsuarioLogin();
				dadosTabela = new DataTable();
				dadosTabela = RetornaUsuario.RetornaUsuario(Convert.ToInt32(UsuarioLogado.idUsuario));

				if (dadosTabela.Rows[0]["USUARIO_LOGIN"].ToString() != usuario)
					validacoes.ValidaUsuario(usuario);

				if (dadosTabela.Rows[0]["EMAIL_LOGIN"].ToString() != email)
					validacoes.ValidaEmail(email);
			}
			catch (Exception)
			{

				throw;
			}
		}

		internal void ValidaAlteracao(string usuario, string email, string senha)
		{
			try
			{
				if (usuario.Trim().Length == 0)
					throw new Exception("O Campo Nome Úsuario não pode ser vazio!");

				if (email.Trim().Length == 0)
					throw new Exception("O Campo Email não pode ser vazio!");

				RetornaUsuario = new RetornaUsuarioLogin();
				dadosTabela = new DataTable();
				dadosTabela = RetornaUsuario.RetornaUsuario(Convert.ToInt32(UsuarioLogado.idUsuario));

				if (dadosTabela.Rows[0]["USUARIO_LOGIN"].ToString() != usuario)
					validacoes.ValidaUsuario(usuario);

				if (dadosTabela.Rows[0]["EMAIL_LOGIN"].ToString() != email)
					validacoes.ValidaEmail(email);

				if (dadosTabela.Rows[0]["SENHA_LOGIN"].ToString() != senha)
					validacoes.ValidaSenha(senha);

			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
