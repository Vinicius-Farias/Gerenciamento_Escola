using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RegraNegocio
{
    public class Principal
    {
        public void testandoConexao()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(Conexao.stringConexao))
                {
                    conexao.Open();
                }
            }
            catch (Exception)
            {

                throw new Exception("Não conectou!");
            }
        }

        public DataTable ListarAlunos()
        {
            try
            {
                RetornaAluno retornaAluno = new RetornaAluno();
                DataTable dadosTabela = new DataTable();
				return dadosTabela = retornaAluno.RetornaAlunos();
			}
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
