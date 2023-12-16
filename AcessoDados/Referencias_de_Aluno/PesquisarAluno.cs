using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
	public class PesquisarAluno
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable PesquisaNome(string nome)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Cadastro_Aluno ");
					sql.Append("WHERE NOME_ALUNO LIKE '%'+@nome+'%' ");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaNome da class PesquisarAluno!");
			}
		}

		public DataTable PesquisaRg(string rg)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Cadastro_Aluno ");
					sql.Append("WHERE RG_ALUNO LIKE '%'+@rg+'%'");

					comandoSql.Parameters.Add(new SqlParameter("@rg", rg));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaRg da Class PesquisarAluno!");
			}
		}

		public DataTable PesquisaCpf(string cpf)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Cadastro_Aluno ");
					sql.Append("WHERE CPF_ALUNO LIKE '%'+@cpf+'%'");

					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método PesquisaCpf da Class PesquisarAluno!");
			}
		}
	}
}
