using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.Referencias_de_Login.Entrada_de_Login;
using RegraNegocio.Variaves_Globais;

namespace RegraNegocio.Referencia_de_Login.Validacoes_Login
{
	public class EntradaLogin
	{
		public bool RetornaLogin(string usuario, string senha)
		{
			try
			{
				ValidaLogin validaLogin = new ValidaLogin();
				DataTable dadosTabela = new DataTable();

				dadosTabela = validaLogin.VerificarLogin(usuario ,CriptografiaSenha.GerarHashSenha(senha));

				if(dadosTabela.Rows.Count > 0)
				{
					UsuarioLogado.idUsuario = dadosTabela.Rows[0]["ID_LOGIN"].ToString();
					UsuarioLogado.usuario = dadosTabela.Rows[0]["USUARIO_LOGIN"].ToString();
					UsuarioLogado.nivel = dadosTabela.Rows[0]["NIVEL_LOGIN"].ToString();
					UsuarioLogado.email = dadosTabela.Rows[0]["EMAIL_LOGIN"].ToString();
					return true;
				}
				else
				{
					throw new Exception("Úsuario não encontrado Nome de Usuario ou Senha está Incorreto!");
				}

			}
			catch (Exception)
			{
				throw;
					
			}
		}
	}
}
