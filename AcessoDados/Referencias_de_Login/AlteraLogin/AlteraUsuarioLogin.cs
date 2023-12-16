using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login.AlteraLogin
{
	public class AlteraUsuarioLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraUsuario(string usuario, int idLogin)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Login ");
					sql.Append("SET USUARIO_LOGIN = @usuario ");
					sql.Append("WHERE (ID_LOGIN = @idLogin)");

					comandoSql.Parameters.Add(new SqlParameter("@usuario", usuario));
					comandoSql.Parameters.Add(new SqlParameter("@idLogin", idLogin));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método AlteraUsuario da Class AlteraUsuarioLogin!");
			}
		}
	}
}
