using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace EnableProxy
{
	class Command
	{
		private const string help = "h";
		//private const string helpMsg = "hm";
		private const string status = "s";
		private const string enableProxy = "e";
		private const string disableProxy = "d";
		private const string runWithoutCommand = "rwoc";
		private const string start = "-";
		/// <summary>
		/// コマンドライン引数を確認すして、処理します
		/// </summary>
		/// <returns>0: フォームを起動する, 1: フォームを起動しない, -1: 引数がおかしい</returns>
		public static int CheckCommandLines(string[] args)
		{
			if (args.Length == 0)
			{
				return 0;
			}

			if (args.Contains<string>(start + help) == true)
			{
				Console.WriteLine(ShowHelp());
				return 1;
			}

			if (args.Contains<string>(start + runWithoutCommand) == true)
			{
				// メッセージボックスで表示
				// help
				if (args.Contains<string>(start + help) == true)
				{
					Console.WriteLine(ShowHelp());
					return 1;
				}
				// status
				else if (args.Contains<string>(start + status) == true)
				{
					MessageBox.Show(ShowStatus());
					return 1;
				}
				else
				{
					Console.WriteLine("無効な引数です\n\n");
					Console.WriteLine(ShowHelp());
				}

			}
			else
			{
				// コンソールで表示
				// help
				if (args.Contains<string>(start + help) == true)
				{
					Console.WriteLine(ShowHelp());
					return 1;
				}
				// status
				else if (args.Contains<string>(start + status) == true)
				{
					Console.WriteLine(ShowStatus());
					return 1;
				}
				else
				{
					MessageBox.Show("無効な引数です\n\n" + ShowHelp());
				}
			}

			if (args.Contains<string>(start + status) == true)
			{

			}
			foreach (string item in args)
			{

			}
			return 0;
		}

		private static string ShowHelp()
		{
			string version = "プロキシ サーバーを使用する - ヘルプ\n" +
				FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
			string cmd = "使用法:\n" +
				start + help + " : ヘルプを表示します\n" +
				start + enableProxy + " : プロキシ サーバーを使用します\n" +
				start + disableProxy + " : プロキシ サーバーを無効にします\n" +
				start + runWithoutCommand + " : コマンドラインの代わりにメッセージボックスで操作します";
			return version + "\n" + cmd + "\n";
		}

		private static string ShowStatus()
		{
			string ret;
			object objEnable, objServer, objOverride;
			bool enabled;
			string address;
			string port;
			bool localAddress;

			RegKeyIO.ReadKey(out objEnable, out objServer, out objOverride);
			RegKeyIO.ConvertReadKey(
				objEnable, objServer, objOverride, 
				out enabled, out address, out port, out localAddress);

			ret = "現在の状態\n";
			ret += "LAN にプロキシ サーバーを使用する : " + enabled.ToString() + "\n";
			ret += "アドレス : " + address + "\n";
			ret += "ポート : " + port + "\n";
			ret += "ローカル アドレスでもプロキシ サーバーを使用する : " + 
				localAddress.ToString() + "\n";
			return ret;
		}
	}
}
