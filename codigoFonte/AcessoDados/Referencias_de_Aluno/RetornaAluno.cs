using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
	public class RetornaAluno
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();
		DataTable dadosTabela = new DataTable();

		public DataTable RetornaId(int idAluno)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Cadastro_Aluno ");
					sql.Append("WHERE (ID_ALUNO = @idAluno)");

					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método RetornaRg da Class RetornaAluno!");
			}
		}

		public DataTable RetornaRg(string rg)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT RG_ALUNO FROM Cadastro_Aluno ");
					sql.Append("WHERE (RG_ALUNO = @rg)");

					comandoSql.Parameters.Add(new SqlParameter("@rg", rg));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;	
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método RetornaRg da Class RetornaAluno!");
			}
		}

		public DataTable RetornaCpf(string cpf)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT CPF_ALUNO FROM Cadastro_Aluno ");
					sql.Append("WHERE (CPF_ALUNO = @cpf)");

					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método RetornaCpf da Class RetornaAluno!");
			}
		}

		public DataTable RetornaAlunos()
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("SELECT * FROM Cadastro_Aluno ");
					sql.Append("ORDER BY ID_ALUNO DESC");

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					dadosTabela.Load(comandoSql.ExecuteReader());
					return dadosTabela;
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método RetornaAlunos da class RetornaAluno!");
			}
		}
	}
}
