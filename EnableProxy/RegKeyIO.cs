using System;
using System.Diagnostics;
//using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using EnableProxy.Properties;
using Microsoft.Win32;
using System.Drawing;
using System.Text;

namespace EnableProxy
{
	class RegKeyIO
	{
		Main main;
		public const char AddressSeparate = ':';
		public const string LocalAddress = "<local>";


		/// <summary>
		/// RegKeyのメインエントリポイント
		/// </summary>
		public RegKeyIO(Main m)
		{
			main = m;
		}

		/// <summary>
		/// キーを取得(GUI)
		/// </summary>
		public void ReadKeyGui(bool isStartup = false)
		{
			object objEnable, objServer, objOverride;
			bool enabled;
			string address;
			string port;
			bool localAddress;
			//int proxyEnable;
			//string proxyServer;
			//string proxyOverride;

			try
			{
				if (isStartup == false)
				{
					main.Status("キーを読み込んでます...");
				}
				// レジストリを開く
				ReadKey(out objEnable, out objServer, out objOverride);
				ConvertReadKey(
					objEnable, objServer, objOverride, 
					out enabled, out address, out port, out localAddress);
				//proxyEnable = (int)objEnable;
				//proxyServer = (string)objServer;
				//proxyOverride = (string)objOverride;

				//RegistryKey regkey =
				//    Registry.CurrentUser.OpenSubKey(@Settings.Default.InternetSettingsKey, false);

				// プロキシ
				string mainText = Settings.Default.Title + main.TitleSeparate;
				if (enabled == true)
				{
					main.chkEnableProxy.Checked = true;
					main.Text = mainText + Main.Enable;
				}
				else
				{
					main.chkEnableProxy.Checked = false;
					main.Text = mainText + Main.Disable;
				}
				//int proxyEnable = (int)regkey.GetValue(Settings.Default.ProxyEnable);
				//switch (proxyEnable)
				//{
				//    case 0:
				//        main.chkEnableProxy.Checked = false;
				//        main.Text = Settings.Default.Title + main.TitleSeparate + Main.Disable;
				//        break;
				//    case 1:
				//        main.chkEnableProxy.Checked = true;
				//        main.Text = Settings.Default.Title + main.TitleSeparate + Main.Enable;
				//        break;
				//    default:
				//        break;
				//}


				// アドレス
				//string proxyServer =
				//	(string)regkey.GetValue(Settings.Default.ProxyServer);
				//string[] PSS = proxyServer.Split(new char[] { AddressSeparate });
				//string address = PSS[0];
				//string port = PSS[1];
				main.txtAddress.Text = address;
				main.txtPort.Text = port;

				// ローカルアドレス
				//string proxyOverride =
				//	(string)regkey.GetValue(Settings.Default.ProxyOverride);
				//if (proxyOverride == LocalAddress)
				//{
				//    main.chkLocalAddress.Checked = false;
				//}
				//else
				//{
				//    main.chkLocalAddress.Checked = true;
				//}
				main.chkLocalAddress.Checked = localAddress;

				//regkey.Close();
				if (isStartup == false)
				{
					main.Status("キー読み込みに成功しました");
				}
				else
				{
					main.Status("");
				}
			}
			catch (Exception ex)
			{
				main.exMessage(ref ex);
			}
		}



		public static int ReadKey(out object proxyEnable, out object proxyServer, out object proxyOverride)
		{
			RegistryKey regkey =
				Registry.CurrentUser.OpenSubKey(Settings.Default.InternetSettingsKey, false);
			proxyEnable = regkey.GetValue(Settings.Default.ProxyEnable); // プロキシ
			proxyServer = regkey.GetValue(Settings.Default.ProxyServer); // アドレス
			proxyOverride = regkey.GetValue(Settings.Default.ProxyOverride); // ローカルアドレス
			return 0;
		}

		public static int ConvertReadKey(
			object proxyEnable, object proxyServer, object proxyOverride,
			out bool enabled, out string address, out string port, out bool localAddress)
		{
			int result = 0;
			enabled = false;
			address = "";
			port = "";
			localAddress = false;

			try
			{
				// プロキシ
				int iEnable = (int)proxyEnable;
				switch (iEnable)
				{
					case 0:
						enabled = false;
						break;
					case 1:
						enabled = true;
						break;
					default:
						enabled = false;
						result = -1;
						break;
				}
				// アドレス
				string strServer = proxyServer == null ? "" : (string)proxyServer;
				string[] PSS = strServer.Split(new char[] { AddressSeparate });
				if (PSS == null)
				{
					address = port = "";
				}
				else
				{
					if (PSS.Length > 0)
						address = PSS[0];
					if (PSS.Length > 1)
						port = PSS[1];
				}
				//address = PSS[0];
				
				//port = PSS[1];

				// ローカルアドレス
				string strOverride = proxyOverride == null ? "" : (string)proxyOverride;
				//string strOverride = (string)proxyOverride;
				if (strOverride == LocalAddress)
				{
					localAddress = false;
				}
				else
				{
					localAddress = true;
				}
				result = 0;
			}
			catch (Exception)
			{
				result = -1;
				throw;
			}

			return result;
		}

		/// <summary>
		/// キーを保存(GUI)
		/// </summary>
		public void SaveKeyGui()
		{
			try
			{
				main.Status("キーを保存するための前処理を行っています...");
				//// レジストリを開く
				//RegistryKey regkey =
				//    Registry.CurrentUser.OpenSubKey(@Settings.Default.InternetSettingsKey, true);

				// プロキシ
				int proxyEnable;
				if (main.chkEnableProxy.Checked == true)
				{
					proxyEnable = 1;
				}
				else
				{
					proxyEnable = 0;
				}

				// アドレス
				string proxyServer;
				proxyServer = main.txtAddress.Text + AddressSeparate + main.txtPort.Text;

				// ローカルアドレス
				string proxyOverride;
				if (main.chkLocalAddress.Checked == true)
				{
					proxyOverride = Settings.Default.ProxyOverrideAddress;
				}
				else
				{
					proxyOverride = LocalAddress;
				}

				// キーを保存
				main.Status("キーを保存しています...");
				SaveKey(proxyEnable, proxyServer, proxyOverride);
				//regkey.SetValue(Settings.Default.ProxyEnable, proxyEnable); // プロキシ
				//regkey.SetValue(Settings.Default.ProxyServer, proxyServer); // アドレス
				//regkey.SetValue(Settings.Default.ProxyOverride, proxyOverride); // ローカルアドレス
				//regkey.Close();
				main.Status("キーを保存しました");
			}
			catch (Exception ex)
			{
				main.exMessage(ref ex);
			}
		}

		public static int SaveKey(object proxyEnable, object proxyServer, object proxyOverride)
		{
			RegistryKey regkey =
				Registry.CurrentUser.OpenSubKey(Settings.Default.InternetSettingsKey, true);
			regkey.SetValue(Settings.Default.ProxyEnable, proxyEnable); // プロキシ
			regkey.SetValue(Settings.Default.ProxyServer, proxyServer); // アドレス
			regkey.SetValue(Settings.Default.ProxyOverride, proxyOverride); // ローカルアドレス
			regkey.Close();

			return 0;
		}
	}
}
