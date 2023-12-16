using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEscola
{
	internal static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			frmEntraLogin entraLogin = new frmEntraLogin();
			entraLogin.ShowDialog();

			if(entraLogin.DialogResult == DialogResult.OK)
			{
				Application.Run(new frmPrincipal());
			}
			else
			{
				Application.Exit();
			}
			
		}
	}
}
