using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.Referencia_de_Login.Validacoes_Login
{
	public static class CriptografiaSenha
	{
		public static string GerarHashSenha(string senha)
		{

			try
			{
				if (senha.Trim().Length < 8)
					throw new Exception("O campo senha não pode ter menos de 8 caracteres");

				using (SHA256 sha256 = SHA256.Create())
				{
					byte[] bytes = Encoding.UTF8.GetBytes(senha);
					byte[] hashBytes = sha256.ComputeHash(bytes);

					StringBuilder hashBuilder = new StringBuilder();
					for (int i = 0; i < hashBytes.Length; i++)
					{
						hashBuilder.Append(hashBytes[i].ToString("x2"));
					}

					return hashBuilder.ToString();
				}
			}
			catch (Exception)
			{

				throw;
			}
			
		}
	}
}
