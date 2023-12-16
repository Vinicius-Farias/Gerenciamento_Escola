using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;

namespace RegraNegocio
{
	public class ExcluirAlunoRegraNegocio
	{
		public void ExcluiAluno(int idAluno)
		{
			try
			{
				ExcluirAluno excluir = new ExcluirAluno();
				excluir.Excluir(idAluno);
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
