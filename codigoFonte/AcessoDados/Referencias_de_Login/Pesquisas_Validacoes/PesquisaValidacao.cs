using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados.Referencias_de_Login.Pesquisas_Validacoes
{
	public class PesquisaValidacao
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable PesquisaUsuario(string usuario)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT USUARIO_LOGIN FROM Login ");
					sql.Append("WHERE (USUARIO_LOGIN = @usuario)");

					comandoSql.Parameters.Add(new SqlParameter("@usuario", usuario));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaUsuario da class PesquisaValidacao!");
			}
		}

		public DataTable PesquisaSenha(string senha)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT SENHA_LOGIN FROM Login ");
					sql.Append("WHERE (SENHA_LOGIN = @senha)");

					comandoSql.Parameters.Add(new SqlParameter("@senha", senha));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaSenha da class PesquisaValidacao!");
			}
		}

		public DataTable PesquisaEmail(string email)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT EMAIL_LOGIN FROM Login ");
					sql.Append("WHERE (EMAIL_LOGIN = @email)");

					comandoSql.Parameters.Add(new SqlParameter("@email", email));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaEmail da class PesquisaValidacao!");
			}
		}
	}
}
