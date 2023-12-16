using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using RegraNegocio.Variaves_Globais;

namespace RegraNegocio.Referencia_de_Login.Validacoes_Login
{
	public class EnviarEmailLogin
	{
		
		private string GerarCodigoVerificacao()
		{
			Random random = new Random();
			return random.Next(100000, 999999).ToString();
		}

		public void EnviarEmail(string email)
		{
			try
			{
				UsuarioLogado.codigo = GerarCodigoVerificacao();

				MailMessage mensagem = new MailMessage();
				mensagem.From = new MailAddress("seu email aqui");
				mensagem.To.Add(email);
				mensagem.Subject = "Confirmação de E-mail";
				mensagem.Body = "Seu código de verificação é: "+ UsuarioLogado.codigo;

				SmtpClient smtp = new SmtpClient();
				smtp.Host = "smtp.gmail.com";
				smtp.Port = 587;
				smtp.UseDefaultCredentials = false;
				smtp.Credentials = new NetworkCredential("seu email aqui", "senha aqui");
				smtp.EnableSsl = true;
				smtp.Send(mensagem);
				
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
