using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login.AlteraLogin
{
	public class AlteraEmailLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraEmail(string email, int idLogin)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Login ");
					sql.Append("SET EMAIL_LOGIN = @email ");
					sql.Append("WHERE (ID_LOGIN = @idLogin)");

					comandoSql.Parameters.Add(new SqlParameter("@email", email));
					comandoSql.Parameters.Add(new SqlParameter("@idLogin", idLogin));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método AlteraEmail da Class AlteraEmailLogin!");
			}
		}
	}
}
