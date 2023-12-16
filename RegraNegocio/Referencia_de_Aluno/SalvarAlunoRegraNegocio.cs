using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;

namespace RegraNegocio
{
	public class SalvarAlunoRegraNegocio
	{
		public void salvarAluno(int idAluno, string nome, string telefone, string sexo, DateTime nascimento, string endereco, 
			string bairro, string cep, string observacoes, string rg, string cpf)
		{
			try
			{
				ValidacoesAluno validacoes = new ValidacoesAluno();
				validacoes.Validar(idAluno, nome, telefone, sexo, nascimento, endereco, bairro, cep, rg, cpf);

				SalvarAluno SalvarnovoAluno = new SalvarAluno();
				SalvarnovoAluno.Salvar(nome, telefone, sexo, nascimento, endereco, bairro, cep, observacoes, rg, cpf);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
