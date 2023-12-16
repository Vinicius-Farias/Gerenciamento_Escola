using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login.Entrada_de_Login
{
	public class ValidaEmailLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadostabela = new DataTable();

		public DataTable VerificaEmail(string email)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT ID_LOGIN, USUARIO_LOGIN, EMAIL_LOGIN FROM Login ");
					sql.Append("WHERE  EMAIL_LOGIN = @email");

					comandoSql.Parameters.Add(new SqlParameter("@email", email));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadostabela.Load(comandoSql.ExecuteReader());
					return dadostabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método VerificaEmail da class ValidaEmailLogin!");
			}
		}

	}
}
