using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
	public class AlteraAluno
	{
		SqlCommand comandoSql = new SqlCommand();
		StringBuilder sql = new StringBuilder();

		public void AlteraCadastro(int idAluno, string nome, string telefone, string sexo, DateTime nascimento, string endereco, 
			string bairro, string cep, string observacoes, string rg, string cpf)
		{
			try
			{
				using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
				{
					conexao.Open();

					sql.Append("UPDATE Cadastro_Aluno ");
					sql.Append("SET NOME_ALUNO = @nome, TELEFONE_ALUNO = @telefone, GENERO_ALUNO = @sexo, NASCIMENTO_ALUNO = @nascimento, ");
					sql.Append("ENDERECO_ALUNO = @endereco, BAIRRO_ALUNO = @bairro, CEP_ALUNO = @cep, OBSERVACOES_ALUNO = @observacoes, ");
					sql.Append("RG_ALUNO = @rg, CPF_ALUNO = @cpf ");
					sql.Append("WHERE ID_ALUNO = @idAluno");

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
					comandoSql.Parameters.Add(new SqlParameter("@idAluno", idAluno));

					comandoSql.CommandText = sql.ToString();
					comandoSql.Connection = conexao;
					comandoSql.ExecuteNonQuery();
				}
			}
			catch (Exception)
			{

				throw new Exception("Erro no método AlteraCadastro da class AlteraAluno");
			}
		}
	}
}
