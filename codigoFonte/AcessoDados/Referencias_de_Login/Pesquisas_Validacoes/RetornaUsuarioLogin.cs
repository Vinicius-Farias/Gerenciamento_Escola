using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login.Pesquisas_Validacoes
{
	public class RetornaUsuarioLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable RetornaUsuario(int idLogin)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Login ");
					sql.Append("WHERE (ID_LOGIN = @idLogin)");

					comandoSql.Parameters.Add(new SqlParameter("@idLogin", idLogin));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{
				throw new Exception("Erro no método RetornaUsuario da Class RetornaUsuarioLogin!");
			}
		}
	}
}
