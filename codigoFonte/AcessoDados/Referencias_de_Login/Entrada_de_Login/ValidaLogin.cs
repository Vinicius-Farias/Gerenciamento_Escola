using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login.Entrada_de_Login
{
	public class ValidaLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable VerificarLogin(string usuario, string senha)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT ID_LOGIN, USUARIO_LOGIN, NIVEL_LOGIN, EMAIL_LOGIN FROM Login ");
					sql.Append("WHERE USUARIO_LOGIN = @usuario AND SENHA_LOGIN = @senha");

					comandoSql.Parameters.Add(new SqlParameter("@usuario", usuario));
					comandoSql.Parameters.Add(new SqlParameter("@senha", senha));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método VerificarLogin da class ValidaLogin!");
			}
		}
	}
}
