using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.Referencias_de_Login;
using AcessoDados.Referencias_de_Login.Pesquisas_Validacoes;
using RegraNegocio.Referencia_de_Login.Validacoes_Login;
using RegraNegocio.Variaves_Globais;

namespace RegraNegocio.Referencia_de_Login
{
	public class AlteraSenhaLogin
	{
		public void AlteraSenha(string senha)
		{
			try
			{
				if (senha.Trim().Length < 8)
					throw new Exception("A senha não pode ter menos de 8 Caracteres");

				AlteraSenhasLogin alteraSenha = new AlteraSenhasLogin();
				alteraSenha.AlteraSenha(Convert.ToInt32(UsuarioLogado.idUsuario), ValidaSenha(CriptografiaSenha.GerarHashSenha(senha)));
			}
			catch (Exception)
			{

				throw;
			}
		}

		private string ValidaSenha(string senha)
		{
			try
			{
				PesquisaValidacao validacao = new PesquisaValidacao();
				DataTable dadosTabela = new DataTable();
				dadosTabela = validacao.PesquisaSenha(senha);

				if (dadosTabela.Rows.Count > 0)
					throw new Exception("Está senha já está em uso digite outra!");

				return senha;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
