using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login
{
	public class AlteraSenhasLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraSenha(int idLogin, string senha)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Login ");
					sql.Append("SET SENHA_LOGIN = @senha ");
					sql.Append("WHERE (ID_LOGIN = @idLogin)");

					comandoSql.Parameters.Add(new SqlParameter("@senha", senha));
					comandoSql.Parameters.Add(new SqlParameter("@idLogin", idLogin));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método AlteraSenha da Class AlteraLogin!");
			}
		}
	}
}
