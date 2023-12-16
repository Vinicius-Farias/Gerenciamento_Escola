using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.Referencias_de_Login.Pesquisas_Validacoes;

namespace RegraNegocio.Referencia_de_Login.Validacoes_Login
{
	internal class ValidacoesLogin
	{
		PesquisaValidacao validacao;
		DataTable dadosTabela;

		internal void ValidaCampos(string usuario, string senha, string nivel, string email)
		{
			try
			{
				if (usuario.Trim().Length == 0)
					throw new Exception("O Campo Nome de Úsuario não pode está vazio!");
				
				if (nivel.Trim().Length == 0)
					throw new Exception("O Campo Nivel de Úsuario não pode está vazio!");
				
				if (email.Trim().Length == 0)
					throw new Exception("O Campo Email não pode está vazio!");
				
				ValidaUsuario(usuario);
				ValidaSenha(senha);
				ValidaEmail(email);
			}
			catch (Exception)
			{

				throw;
			}
		}

		internal void ValidaUsuario(string usuario)
		{
			try
			{
				validacao = new PesquisaValidacao();
				dadosTabela = new DataTable();
				dadosTabela = validacao.PesquisaUsuario(usuario);

				if (dadosTabela.Rows.Count > 0)
					throw new Exception("Nome de ùsuario já está em uso digite outra!");
				
			}
			catch (Exception)
			{

				throw;
			}
		}

		internal void ValidaSenha(string senha)
		{
			try
			{
				validacao = new PesquisaValidacao();
				dadosTabela = new DataTable();
				dadosTabela = validacao.PesquisaSenha(senha);

				if (dadosTabela.Rows.Count > 0)
					throw new Exception("Está senha já está em uso digite outra!");

			}
			catch (Exception)
			{

				throw;
			}
		}

		internal void ValidaEmail(string email)
		{
			try
			{
				EmailValido(email);	

				validacao = new PesquisaValidacao();
				dadosTabela = new DataTable();
				dadosTabela = validacao.PesquisaEmail(email);

				if (dadosTabela.Rows.Count > 0)
					throw new Exception("Este Email já está em uso digite outro!");

			}
			catch (Exception)
			{

				throw;
			}
		}

		internal void EmailValido(string email)
		{
			try
			{
				MailAddress mailAddress = new MailAddress(email);
			}
			catch (Exception)
			{
				throw new Exception("Este Email é invalido digite outro!");
			}
		}
	}
}
