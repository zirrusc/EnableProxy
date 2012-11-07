namespace EnableProxy
{
	partial class Setting
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtHelpFile = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkTopMost = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nudPingByte = new System.Windows.Forms.NumericUpDown();
			this.nudPingTtl = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.chkPingFragment = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPingSubmitAddress = new System.Windows.Forms.TextBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.chkEnableVisualStyle = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPingByte)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPingTtl)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "タイトル(&T):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "ヘルプファイル(&H):";
			// 
			// txtTitle
			// 
			this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTitle.Location = new System.Drawing.Point(106, 22);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(218, 23);
			this.txtTitle.TabIndex = 1;
			// 
			// txtHelpFile
			// 
			this.txtHelpFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtHelpFile.Location = new System.Drawing.Point(106, 51);
			this.txtHelpFile.Name = "txtHelpFile";
			this.txtHelpFile.Size = new System.Drawing.Size(218, 23);
			this.txtHelpFile.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.chkEnableVisualStyle);
			this.groupBox1.Controls.Add(this.chkTopMost);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtHelpFile);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTitle);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(330, 139);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "全般";
			// 
			// chkTopMost
			// 
			this.chkTopMost.AutoSize = true;
			this.chkTopMost.Location = new System.Drawing.Point(9, 80);
			this.chkTopMost.Name = "chkTopMost";
			this.chkTopMost.Size = new System.Drawing.Size(154, 19);
			this.chkTopMost.TabIndex = 4;
			this.chkTopMost.Text = "常に最前面で表示する(&V)";
			this.chkTopMost.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(166, 325);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 35);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(91, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 29);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "キャンセル";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(3, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(82, 29);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.nudPingByte);
			this.groupBox2.Controls.Add(this.nudPingTtl);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.chkPingFragment);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtPingSubmitAddress);
			this.groupBox2.Location = new System.Drawing.Point(12, 157);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(330, 162);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ping";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 102);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "バイト数(&B):";
			// 
			// nudPingByte
			// 
			this.nudPingByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPingByte.Location = new System.Drawing.Point(204, 100);
			this.nudPingByte.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
			this.nudPingByte.Name = "nudPingByte";
			this.nudPingByte.Size = new System.Drawing.Size(120, 23);
			this.nudPingByte.TabIndex = 5;
			this.nudPingByte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// nudPingTtl
			// 
			this.nudPingTtl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nudPingTtl.Location = new System.Drawing.Point(204, 71);
			this.nudPingTtl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPingTtl.Name = "nudPingTtl";
			this.nudPingTtl.Size = new System.Drawing.Size(120, 23);
			this.nudPingTtl.TabIndex = 3;
			this.nudPingTtl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 53);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(275, 15);
			this.label4.TabIndex = 2;
			this.label4.Text = "データを転送できるルーターやゲートウェイの数の上限(&L):";
			// 
			// chkPingFragment
			// 
			this.chkPingFragment.AutoSize = true;
			this.chkPingFragment.Location = new System.Drawing.Point(6, 129);
			this.chkPingFragment.Name = "chkPingFragment";
			this.chkPingFragment.Size = new System.Drawing.Size(307, 19);
			this.chkPingFragment.TabIndex = 6;
			this.chkPingFragment.Text = "インターネット プロトコル データグラムの断片化を許可する(&I)";
			this.chkPingFragment.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "送信先(&S):";
			// 
			// txtPingSubmitAddress
			// 
			this.txtPingSubmitAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPingSubmitAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtPingSubmitAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
			this.txtPingSubmitAddress.Location = new System.Drawing.Point(106, 22);
			this.txtPingSubmitAddress.Name = "txtPingSubmitAddress";
			this.txtPingSubmitAddress.Size = new System.Drawing.Size(218, 23);
			this.txtPingSubmitAddress.TabIndex = 1;
			// 
			// btnReset
			// 
			this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnReset.Location = new System.Drawing.Point(12, 328);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(82, 29);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "リセット(&R)";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// chkEnableVisualStyle
			// 
			this.chkEnableVisualStyle.AutoSize = true;
			this.chkEnableVisualStyle.Location = new System.Drawing.Point(9, 105);
			this.chkEnableVisualStyle.Name = "chkEnableVisualStyle";
			this.chkEnableVisualStyle.Size = new System.Drawing.Size(164, 19);
			this.chkEnableVisualStyle.TabIndex = 5;
			this.chkEnableVisualStyle.Text = "視覚的効果を有効にする(&E)";
			this.chkEnableVisualStyle.UseVisualStyleBackColor = true;
			// 
			// Setting
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(354, 372);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Setting";
			this.Text = "設定";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPingByte)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPingTtl)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtHelpFile;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPingSubmitAddress;
		private System.Windows.Forms.CheckBox chkPingFragment;
		private System.Windows.Forms.NumericUpDown nudPingTtl;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nudPingByte;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.CheckBox chkTopMost;
		private System.Windows.Forms.CheckBox chkEnableVisualStyle;
	}
}