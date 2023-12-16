using AcessoDados.Referencias_de_Login.Pesquisas_Validacoes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using AcessoDados.Referencias_de_Login.Entrada_de_Login;
using RegraNegocio.Variaves_Globais;

namespace RegraNegocio.Referencia_de_Login.Validacoes_Login
{
	public class ConfirmaEmailLogin
	{
		private readonly ValidaEmailLogin emailLogin = new ValidaEmailLogin();
		private readonly EnviarEmailLogin EnviarEmail = new EnviarEmailLogin();
		DataTable dadosTabela;

		public void ConfirmaEmail(string email)
		{
			try
			{
				if (email.Trim().Length == 0)
					throw new Exception("O Campo Email não pode está vazio!");

				ValidaEmail(email);
				EnviarEmail.EnviarEmail(email);

			}
			catch (Exception)
			{

				throw;
			}
		}
		private void ValidaEmail(string email)
		{
			try
			{
				EmailValido(email);
				dadosTabela = new DataTable();
				dadosTabela = emailLogin.VerificaEmail(email);

				if (dadosTabela.Rows.Count > 0)
				{
					UsuarioLogado.idUsuario = dadosTabela.Rows[0]["ID_LOGIN"].ToString();
					UsuarioLogado.usuario = dadosTabela.Rows[0]["USUARIO_LOGIN"].ToString();
					UsuarioLogado.email = dadosTabela.Rows[0]["EMAIL_LOGIN"].ToString();
				}
				else
				{
					throw new Exception("Esse email não está cadastrado em nosso sistema tente outro!");
				}

			}
			catch (Exception)
			{

				throw;
			}
		}

		private void EmailValido(string email)
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
