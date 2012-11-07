using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnableProxy.Properties;

namespace EnableProxy
{
	public partial class Setting : Form
	{
		Main main;

		public Setting(Main m)
		{
			InitializeComponent();
			main = m;
			this.Icon = main.Icon;
			ReadSettings();
		}

		private void ReadSettings()
		{
			txtTitle.Text = Settings.Default.Title;
			txtHelpFile.Text = Settings.Default.helpFile;
			chkTopMost.Checked = Settings.Default.TopMost;
			chkEnableVisualStyle.Checked = Settings.Default.VisualStyle;

			txtPingSubmitAddress.Text = Settings.Default.PingAddress;
			nudPingTtl.Value = Settings.Default.PingTtl;
			nudPingByte.Value = Settings.Default.PingByte;
			chkPingFragment.Checked = !Settings.Default.PingDontFragment;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SaveSettings();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void SaveSettings()
		{
			Settings.Default.Title = txtTitle.Text;
			Settings.Default.helpFile = txtHelpFile.Text;
			Settings.Default.TopMost = chkTopMost.Checked;
			Settings.Default.VisualStyle = chkEnableVisualStyle.Checked;

			string add = txtPingSubmitAddress.Text.Replace("http://", "");
			add = add.Replace("ftp://", "");
			add = add.Replace("https://", "");
			add = add.Replace("ftps://", "");
			add = add.Replace("file:///", "");
			if (add.Substring(add.Length - 1, 1) == "/")
			{
				add = add.Remove(add.Length - 1);
			}
			Settings.Default.PingAddress = txtPingSubmitAddress.Text;
			Settings.Default.PingTtl = (int)nudPingTtl.Value;
			Settings.Default.PingByte = (int)nudPingByte.Value;
			Settings.Default.PingDontFragment = !chkPingFragment.Checked;

			Settings.Default.Save();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			DialogResult dr =
				MessageBox.Show("このアプリケーションの設定を初期値に戻します。\r\n" + 
				"よろしいですか？", "リセット", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);
			if (dr == DialogResult.Yes)
			{
				Settings.Default.Reset();
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
	}
}
