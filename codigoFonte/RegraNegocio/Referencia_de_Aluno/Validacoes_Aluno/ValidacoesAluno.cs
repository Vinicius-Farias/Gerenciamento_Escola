using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;

namespace RegraNegocio
{
    public class ValidacoesAluno
    {
        RetornaAluno retornaAluno;
        DataTable dadosTabela;

		public void Validar(int idAluno, string nome, string telefone, string sexo, DateTime nascimento, string endereco, string bairro, string cep, 
             string rg, string cpf)
        {
            try
            {
                if (nome.Trim().Length == 0)
                    throw new Exception("O Campo Nome não pode ser Vazio!");
                
                if (telefone.Trim().Length == 0)
					throw new Exception("O Campo Telefone não pode ser Vazio!");
				
                if (sexo.Trim().Length == 0)
					throw new Exception("O Campo Sexo não pode ser Vazio selecione um sexo!");
				
                if (nascimento == DateTime.Today)
					throw new Exception("O Campo Nascimento não pode esta com a mesma data atual selecione outra!");
				
                if (endereco.Trim().Length == 0)
					throw new Exception("O Campo Endereço não pode ser Vazio!");
				
                if (bairro.Trim().Length == 0)
					throw new Exception("O Campo Bairro não pode ser Vazio!");
				
                if (cep.Trim().Length == 0)
					throw new Exception("O Campo Cep não pode ser Vazio!");
				
				if (rg.Trim().Length == 0)
					throw new Exception("O campo RG não pode ser vazio!");
				
				if (cpf.Trim().Length == 0)
					throw new Exception("O campo CPF não pode ser vazio!");
				
                if (idAluno > 0)
                {
                    ValidarAlteracaoRgCpf(rg, cpf, idAluno);
                }
                else
                {
                    ValidarCpf(cpf);
                    ValidarRg(rg);
                }
				    
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarAlteracaoRgCpf(string rg, string cpf, int idAluno)
        {
            try
            {
                retornaAluno = new RetornaAluno();
                dadosTabela = new DataTable();
                dadosTabela = retornaAluno.RetornaId(idAluno);

                if (dadosTabela.Rows[0]["CPF_ALUNO"].ToString() != cpf)
                    ValidarCpf(cpf);
                
				retornaAluno = new RetornaAluno();
				dadosTabela = new DataTable();
				dadosTabela = retornaAluno.RetornaId(idAluno);

                if (dadosTabela.Rows[0]["RG_ALUNO"].ToString() != rg)
                    ValidarRg(rg);
                
			}
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarCpf(string cpf)
        {
            try
            {
				retornaAluno = new RetornaAluno();
				dadosTabela = new DataTable();
				dadosTabela = retornaAluno.RetornaCpf(cpf);

				if (dadosTabela.Rows.Count > 0)
					throw new Exception("CPF Já Cadastrado, Cadastre um novo CPF");
				
			}
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarRg(string rg)
        {
            try
            {
                 retornaAluno = new RetornaAluno();
                dadosTabela = new DataTable();
                dadosTabela = retornaAluno.RetornaRg(rg);

                if(dadosTabela.Rows.Count > 0)
                    throw new Exception("RG Já Cadastrado, Cadastre um novo RG");
                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
