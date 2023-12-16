using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
	public class SalvarLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void SalvarLogins(string usuario, string senha, string nivel, string email)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("INSERT INTO Login (USUARIO_LOGIN, SENHA_LOGIN, NIVEL_LOGIN, EMAIL_LOGIN) ");
					sql.Append("VALUES (@usuario, @senha, @nivel, @email)");

					comandoSql.Parameters.Add(new SqlParameter("@usuario", usuario));
					comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
					comandoSql.Parameters.Add(new SqlParameter("@nivel", nivel));
					comandoSql.Parameters.Add(new SqlParameter("@email", email));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método SalvarLogins da class SalvarLogin!");
			}
		}
	}
}
