using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login.Pesquisas_Validacoes
{
	public class PesquisarLogin
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable ListaLogins()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT ID_LOGIN, USUARIO_LOGIN, NIVEL_LOGIN, EMAIL_LOGIN FROM Login ");
					sql.Append("ORDER BY ID_LOGIN DESC");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método ListaLogins da class PesquisarLogin referencia de Login!");
			}
		}

		public DataTable PesquisaUsuario(string usuario)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT ID_LOGIN, USUARIO_LOGIN, NIVEL_LOGIN, EMAIL_LOGIN FROM Login ");
					sql.Append("WHERE USUARIO_LOGIN LIKE '%'+@usuario+'%' ");

					comandoSql.Parameters.Add(new SqlParameter("@usuario",usuario));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaUsuario da class PesquisarLogin referencia de Login!");
			}
		}

		public DataTable PesquisaEmail(string email) 
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT ID_LOGIN, USUARIO_LOGIN, NIVEL_LOGIN, EMAIL_LOGIN FROM Login ");
					sql.Append("WHERE EMAIL_LOGIN LIKE '%'+@email+'%' ");

					comandoSql.Parameters.Add(new SqlParameter("@email", email));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaEmail da class PesquisarLogin referencia de Login!");
			}
		}
	}
}
