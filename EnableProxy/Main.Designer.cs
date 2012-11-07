namespace EnableProxy
{
	partial class Main
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.chkLocalAddress = new System.Windows.Forms.CheckBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.lblPort = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.chkEnableProxy = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnSubmitPing = new System.Windows.Forms.Button();
			this.timerStatus = new System.Windows.Forms.Timer(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkLocalAddress
			// 
			this.chkLocalAddress.AutoSize = true;
			this.chkLocalAddress.Location = new System.Drawing.Point(15, 71);
			this.chkLocalAddress.Name = "chkLocalAddress";
			this.chkLocalAddress.Size = new System.Drawing.Size(328, 22);
			this.chkLocalAddress.TabIndex = 5;
			this.chkLocalAddress.Text = "ローカル アドレスでもプロキシ サーバーを使用する(&L)";
			this.chkLocalAddress.UseVisualStyleBackColor = true;
			// 
			// txtPort
			// 
			this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPort.Location = new System.Drawing.Point(413, 40);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(59, 25);
			this.txtPort.TabIndex = 4;
			// 
			// lblPort
			// 
			this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPort.AutoSize = true;
			this.lblPort.Location = new System.Drawing.Point(358, 43);
			this.lblPort.Name = "lblPort";
			this.lblPort.Size = new System.Drawing.Size(49, 18);
			this.lblPort.TabIndex = 3;
			this.lblPort.Text = "ポート:";
			// 
			// txtAddress
			// 
			this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddress.Location = new System.Drawing.Point(79, 40);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(273, 25);
			this.txtAddress.TabIndex = 2;
			// 
			// lblAddress
			// 
			this.lblAddress.AutoSize = true;
			this.lblAddress.Location = new System.Drawing.Point(12, 43);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(61, 18);
			this.lblAddress.TabIndex = 1;
			this.lblAddress.Text = "アドレス:";
			// 
			// chkEnableProxy
			// 
			this.chkEnableProxy.AutoSize = true;
			this.chkEnableProxy.Location = new System.Drawing.Point(12, 12);
			this.chkEnableProxy.Name = "chkEnableProxy";
			this.chkEnableProxy.Size = new System.Drawing.Size(244, 22);
			this.chkEnableProxy.TabIndex = 0;
			this.chkEnableProxy.Text = "LAN にプロキシ サーバーを使用する(&E)";
			this.chkEnableProxy.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.btnSettings, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnHelp, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnOK, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSubmitPing, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 99);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 35);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// btnSettings
			// 
			this.btnSettings.Location = new System.Drawing.Point(91, 3);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(82, 29);
			this.btnSettings.TabIndex = 1;
			this.btnSettings.Text = "設定(&S)";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Location = new System.Drawing.Point(3, 3);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(82, 29);
			this.btnHelp.TabIndex = 0;
			this.btnHelp.Text = "ヘルプ(&H)";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(375, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 29);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "キャンセル";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(287, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(82, 29);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "&OK";
			this.toolTip1.SetToolTip(this.btnOK, "左クリックするとOK（このウィンドウを閉じます）\r\n右クリックすると適用（このウィンドウを閉じずに確定します）");
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.btnOK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOK_MouseDown);
			// 
			// btnSubmitPing
			// 
			this.btnSubmitPing.Location = new System.Drawing.Point(179, 3);
			this.btnSubmitPing.Name = "btnSubmitPing";
			this.btnSubmitPing.Size = new System.Drawing.Size(82, 29);
			this.btnSubmitPing.TabIndex = 2;
			this.btnSubmitPing.Text = "&Ping送信";
			this.btnSubmitPing.UseVisualStyleBackColor = true;
			this.btnSubmitPing.Click += new System.EventHandler(this.btnSubmitPing_Click);
			// 
			// timerStatus
			// 
			this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 250;
			// 
			// txtStatus
			// 
			this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtStatus.Location = new System.Drawing.Point(12, 142);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.Size = new System.Drawing.Size(460, 18);
			this.txtStatus.TabIndex = 8;
			// 
			// Main
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(484, 172);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.chkLocalAddress);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblPort);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.chkEnableProxy);
			this.Controls.Add(this.lblAddress);
			this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Main";
			this.Text = "プロキシ サーバーを使用する";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
			this.Shown += new System.EventHandler(this.Main_Shown);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnSubmitPing;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Timer timerStatus;
		private System.Windows.Forms.ToolTip toolTip1;
		internal System.Windows.Forms.CheckBox chkEnableProxy;
		internal System.Windows.Forms.Label lblAddress;
		internal System.Windows.Forms.CheckBox chkLocalAddress;
		internal System.Windows.Forms.TextBox txtPort;
		internal System.Windows.Forms.Label lblPort;
		internal System.Windows.Forms.TextBox txtAddress;
		internal System.Windows.Forms.TextBox txtStatus;
	}
}

