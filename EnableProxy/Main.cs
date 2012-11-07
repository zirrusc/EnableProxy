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
	public partial class Main : Form
	{

		#region Variable

		RegKeyIO regkey;

		public const string crlf = "\r\n";
	//	public const string LocalAddress = "<local>";
		public string TitleSeparate = " : ";
	//	public const char AddressSeparate = ':';
		public const string Enable = "有効";
		public const string Disable = "無効";
		public readonly Size generalWindowSize = new Size(490, 170);
		public readonly Size statusWindowSize = new Size(490, 200);
		// Ping オブジェクト
		Ping mainPing = null;

		#endregion // Variable

		#region Rogic

		public Main()
		{
			InitializeComponent();
			startup();
		}

		/// <summary>
		/// スタートアップ時の動作
		/// </summary>
		public void startup()
		{
			regkey = new RegKeyIO(this);

			if (Settings.Default.Title == "")
			{
				TitleSeparate = "";
			}
			else
			{
				this.Text = Settings.Default.Title;
			}
			timerStatus.Interval = 5000;
			this.Size = generalWindowSize;
			this.TopMost = Settings.Default.TopMost;
		}



		private void ShowHelp()
		{
			//AboutBox ab = new AboutBox();
			//ab.ShowDialog();
			string url = Settings.Default.helpFile;
			string baseDir = System.AppDomain.CurrentDomain.BaseDirectory;
			baseDir = baseDir.Substring(0, baseDir.Length - 1);
			try
			{
				url = url.Replace(Settings.Default.appDir, baseDir);
				Process.Start(url);
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
				//Status(ex.Message + ":" + url);
			}

		}

		/// <summary>
		/// Pingを送信
		/// </summary>
		public void SubmitPing()
		{
			try
			{
				Status("Pingを送信するために前処理をしています...");
				btnSubmitPing.Text = "中止(&P)";
			
				if (mainPing == null)
				{
					mainPing = new Ping();
					// イベントハンドラ
					mainPing.PingCompleted +=
						new PingCompletedEventHandler(mainPing_PingCompleted);
					// オプション
					//TTLを64、フラグメンテーションを無効にする
					PingOptions opts =
						new PingOptions(
							Settings.Default.PingTtl,
							Settings.Default.PingDontFragment);
					//Pingで送信する32バイトのデータを作成
					string str =
						new string(Settings.Default.PingSendChar, Settings.Default.PingByte);
					byte[] bs =	Encoding.ASCII.GetBytes(str);
					//Pingを送信する
					//タイムアウトを10秒
					Status("Pingを送信しています...");
					mainPing.SendAsync(
						Settings.Default.PingAddress, 
						Settings.Default.PingTimeOut, 
						bs,
						opts, 
						null);
				}
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
			}
		}

		private void mainPing_PingCompleted(object sender, PingCompletedEventArgs e)
		{
			Exception ex = e.Error;
			if (e.Cancelled)
			{
				Status("<Ping失敗>  キャンセルしました");
			}
			else if (e.Error != null)
			{
				if (e.Error.InnerException.Message == "そのようなホストは不明です。")
				{
					Status("<Ping失敗>  そのようなホストは不明です。");
				}
				else
				{
					exMessage(ref ex);
				}
			}
			else
			{
				// 結果を取得
				if (e.Reply.Status == IPStatus.Success)
				{
					Status("<Ping成功>  アドレス:" + e.Reply.Address + "   " +
						"バイト:" + e.Reply.Buffer.Length + "   " +
						"時間:" + e.Reply.RoundtripTime + "   " +
						"TTL:" + e.Reply.Options.Ttl);
				}
				else
				{
					Status("<Ping失敗> " + e.Reply.Status);
				}
			}
			btnSubmitPing.Text = "&Ping送信";
			mainPing = null;
		}

		private void Apply()
		{
			try
			{
				regkey.SaveKeyGui();
				regkey.ReadKeyGui();
				Status("適用しました");
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
			}
		}

		private void ShowSettings()
		{
			Setting s = new Setting(this);
			DialogResult dr = s.ShowDialog();
			if (dr == DialogResult.OK)
			{
				Application.Restart();
			}
		}

		/// <summary>
		/// 現在の進捗を表示します
		/// </summary>
		/// <param name="text">表示する文字列（""にすると、表示を終了します）</param>
		/// <param name="useAnimation">表示するときに、アニメーション効果を使うかどうか</param>
		/// <param name="timeOut">一定の時間が経過すると自動的に終了するかどうか</param>
		public void Status(string text, bool useAnimation = true, bool timeOut = true)
		{
			Size currentSize;
			Size newSize;
			Size endSize;

			txtStatus.Text = text;
			if (timerStatus.Enabled == true)
			{
				timerStatus.Stop();
			}
			// フォームサイズを変更
			if (text == "")
			{
				endSize = generalWindowSize;
			}
			else
			{
				endSize = statusWindowSize;
			}
			if (useAnimation == true && Settings.Default.VisualStyle == true)
			{
				while (true)
				{
					currentSize = this.Size;
					newSize = FormUtil.ChangeFormSizeWithAnimation(currentSize, endSize, 5);
					if (currentSize == newSize)
					{
						break;
					}
					else
					{
						this.Size = newSize;
						this.Refresh();
					}
				}
			}
			else
			{
				this.Size = endSize;
			}

			if (timeOut == true)
			{
				timerStatus.Start();
			}
		}

		public void exMessage(ref Exception ex)
		{
			string targetSite;
			if (ex.TargetSite == null)
			{
				targetSite = "null";
			}
			else
			{
				targetSite = ex.TargetSite.Name;
			}
			string message = ex.Message;
			string innerMessage;
			if (ex.InnerException == null)
			{
				innerMessage = "null";
			}
			else
			{
				innerMessage = ex.InnerException.Message;
			}

			MessageBox.Show(
				"*TargetSite : " + targetSite + crlf + crlf + 
				"*Message : " + message + crlf + crlf + 
				"*InnerException : " + innerMessage,
				"エラー - プロキシ サーバーを使う",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}

		//public void exMessage(string text)
		//{
		//    MessageBox.Show(text,
		//        "エラー",
		//        MessageBoxButtons.OK,
		//        MessageBoxIcon.Error);
		//}

		#endregion // Rogic

		#region Handler

		private void Main_Shown(object sender, EventArgs e)
		{
			try
			{
				regkey.ReadKeyGui(true);
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			try
			{
				regkey.SaveKeyGui();
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
			}
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			ShowHelp();
		}

		private void btnSubmitPing_Click(object sender, EventArgs e)
		{
			try
			{
				if (mainPing == null)
				{
					SubmitPing();
					Status("Pingを受信中...");
				}
				else
				{
					mainPing.SendAsyncCancel();
				}
			}
			catch (Exception ex)
			{
				exMessage(ref ex);
			}
		}
		

		private void btnSettings_Click(object sender, EventArgs e)
		{
			ShowSettings();
		}

		private void btnOK_MouseDown(object sender, MouseEventArgs e)
		{
			//現在どのマウスボタンが押されているか調べる
			if ((Control.MouseButtons & MouseButtons.Right) == MouseButtons.Right)
			{
				Apply();
			}
		}

		private void timerStatus_Tick(object sender, EventArgs e)
		{
			timerStatus.Stop();
			Status("");
		}

		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.Save();
		}

		#endregion // Handler
	}
}
