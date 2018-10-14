namespace Alice
{
	partial class SubscribeWindow
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.subcribeInfo = new System.Windows.Forms.GroupBox();
			this.title = new System.Windows.Forms.TextBox();
			this.url = new System.Windows.Forms.TextBox();
			this.airDays = new System.Windows.Forms.DateTimePicker();
			this.OKButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.episode = new System.Windows.Forms.NumericUpDown();
			this.subcribeInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.episode)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "タイトル：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "話：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "URL：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "放映日：";
			// 
			// subcribeInfo
			// 
			this.subcribeInfo.Controls.Add(this.episode);
			this.subcribeInfo.Controls.Add(this.CloseButton);
			this.subcribeInfo.Controls.Add(this.OKButton);
			this.subcribeInfo.Controls.Add(this.airDays);
			this.subcribeInfo.Controls.Add(this.url);
			this.subcribeInfo.Controls.Add(this.title);
			this.subcribeInfo.Controls.Add(this.label1);
			this.subcribeInfo.Controls.Add(this.label4);
			this.subcribeInfo.Controls.Add(this.label2);
			this.subcribeInfo.Controls.Add(this.label3);
			this.subcribeInfo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.subcribeInfo.Location = new System.Drawing.Point(12, 12);
			this.subcribeInfo.Name = "subcribeInfo";
			this.subcribeInfo.Size = new System.Drawing.Size(636, 177);
			this.subcribeInfo.TabIndex = 4;
			this.subcribeInfo.TabStop = false;
			this.subcribeInfo.Text = "登録内容";
			// 
			// title
			// 
			this.title.Location = new System.Drawing.Point(85, 21);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(545, 25);
			this.title.TabIndex = 4;
			this.title.Text = "ゆるキャン△ 第 n 話";
			// 
			// url
			// 
			this.url.Location = new System.Drawing.Point(85, 84);
			this.url.Name = "url";
			this.url.Size = new System.Drawing.Size(545, 25);
			this.url.TabIndex = 7;
			this.url.Text = "www.example.com/";
			// 
			// airDays
			// 
			this.airDays.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.airDays.Location = new System.Drawing.Point(85, 115);
			this.airDays.Name = "airDays";
			this.airDays.ShowUpDown = true;
			this.airDays.Size = new System.Drawing.Size(156, 25);
			this.airDays.TabIndex = 5;
			this.airDays.ValueChanged += new System.EventHandler(this.airDays_ValueChanged);
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(438, 143);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(93, 28);
			this.OKButton.TabIndex = 9;
			this.OKButton.Text = "設定";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CloseButton
			// 
			this.CloseButton.Location = new System.Drawing.Point(537, 143);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(93, 28);
			this.CloseButton.TabIndex = 10;
			this.CloseButton.Text = "閉じる";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// episode
			// 
			this.episode.Location = new System.Drawing.Point(85, 53);
			this.episode.Name = "episode";
			this.episode.Size = new System.Drawing.Size(120, 25);
			this.episode.TabIndex = 11;
			this.episode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// SubscribeWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 198);
			this.Controls.Add(this.subcribeInfo);
			this.Name = "SubscribeWindow";
			this.Text = "SubscribeWindow";
			this.Load += new System.EventHandler(this.SubscribeWindow_Load);
			this.subcribeInfo.ResumeLayout(false);
			this.subcribeInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.episode)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox subcribeInfo;
		private System.Windows.Forms.TextBox url;
		private System.Windows.Forms.TextBox title;
		private System.Windows.Forms.DateTimePicker airDays;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.NumericUpDown episode;
	}
}