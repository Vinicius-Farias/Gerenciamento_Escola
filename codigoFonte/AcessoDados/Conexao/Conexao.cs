using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class Conexao
    {
		private static string conexao = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Escola;Integrated Security=true";

		public static string stringConexao
		{ get { return conexao; } }

	}
}
