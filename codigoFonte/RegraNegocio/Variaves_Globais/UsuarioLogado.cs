using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio.Variaves_Globais
{
	public static class UsuarioLogado
	{
		public static string idUsuario { get; set; }
		public static string usuario { get; set; }
		public static string nivel { get; set; }
		public static string email { get; set; }
		public static string codigo { get; set; }
		public static bool LoginPadraoCriado { get; set; }
	}
}
