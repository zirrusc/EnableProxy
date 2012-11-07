using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EnableProxy.Properties;

namespace EnableProxy
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//int cl = Command.CheckCommandLines(args);
			//if (cl == 0)
			//{
				if (Settings.Default.VisualStyle == true)
				{
					Application.EnableVisualStyles();
				}
				Application.SetCompatibleTextRenderingDefault(false);
				//Application.Run(new Main());
				if (!MyProcess.ShowPrevProcess())
				{
					Application.Run(new Main());
				}
			//}
			//else
			//{
			//    return;
			//}
		}
	}
}
