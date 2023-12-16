using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
	public class SalvarAluno
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void Salvar(string  nome, string telefone, string sexo, DateTime nascimento, 
			string endereco, string bairro, string cep, string observacoes, string rg, string cpf)
		{
			try
			{
				using (SqlConnection  conexao = new SqlConnection(Conexao.stringConexao)) 
				{
					conexao.Open();

					sql.Append("INSERT INTO Cadastro_Aluno (NOME_ALUNO, TELEFONE_ALUNO, GENERO_ALUNO, NASCIMENTO_ALUNO, ");
					sql.Append("ENDERECO_ALUNO, BAIRRO_ALUNO, CEP_ALUNO, OBSERVACOES_ALUNO, RG_ALUNO, CPF_ALUNO) ");

					sql.Append("VALUES (@nome, @telefone, @sexo, @nascimento, @endereco, @bairro, @cep, @observacoes, @rg, @cpf)");

					comandoSql.Parameters.Add(new SqlParameter("@nome", nome));
					comandoSql.Parameters.Add(new SqlParameter("@telefone", telefone));
					comandoSql.Parameters.Add(new SqlParameter("@sexo", sexo));
					comandoSql.Parameters.Add(new SqlParameter("@nascimento", nascimento));
					comandoSql.Parameters.Add(new SqlParameter("@endereco", endereco));
					comandoSql.Parameters.Add(new SqlParameter("@bairro", bairro));
					comandoSql.Parameters.Add(new SqlParameter("@cep", cep));
					comandoSql.Parameters.Add(new SqlParameter("@observacoes", observacoes));
					comandoSql.Parameters.Add(new SqlParameter("@rg", rg));
					comandoSql.Parameters.Add(new SqlParameter("@cpf", cpf));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método Salvar da Class SalvarAluno!");
			}
		}
	}
}
