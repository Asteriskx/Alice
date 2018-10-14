namespace Alice
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.subscribeButton = new System.Windows.Forms.Button();
			this.settingButton = new System.Windows.Forms.Button();
			this.TabManager = new System.Windows.Forms.TabControl();
			this.tabPageSunday = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabPageMonday = new System.Windows.Forms.TabPage();
			this.listView2 = new System.Windows.Forms.ListView();
			this.tabPageTuesday = new System.Windows.Forms.TabPage();
			this.listView3 = new System.Windows.Forms.ListView();
			this.tabPageWednesday = new System.Windows.Forms.TabPage();
			this.listView4 = new System.Windows.Forms.ListView();
			this.tabPageThursday = new System.Windows.Forms.TabPage();
			this.listView5 = new System.Windows.Forms.ListView();
			this.tabPageFriday = new System.Windows.Forms.TabPage();
			this.listView6 = new System.Windows.Forms.ListView();
			this.tabPageSaturday = new System.Windows.Forms.TabPage();
			this.listView7 = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TabManager.SuspendLayout();
			this.tabPageSunday.SuspendLayout();
			this.tabPageMonday.SuspendLayout();
			this.tabPageTuesday.SuspendLayout();
			this.tabPageWednesday.SuspendLayout();
			this.tabPageThursday.SuspendLayout();
			this.tabPageFriday.SuspendLayout();
			this.tabPageSaturday.SuspendLayout();
			this.SuspendLayout();
			// 
			// subscribeButton
			// 
			this.subscribeButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.subscribeButton.Location = new System.Drawing.Point(737, 568);
			this.subscribeButton.Name = "subscribeButton";
			this.subscribeButton.Size = new System.Drawing.Size(98, 23);
			this.subscribeButton.TabIndex = 0;
			this.subscribeButton.Text = "Subscribe";
			this.subscribeButton.UseVisualStyleBackColor = true;
			this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
			// 
			// settingButton
			// 
			this.settingButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.settingButton.Location = new System.Drawing.Point(841, 568);
			this.settingButton.Name = "settingButton";
			this.settingButton.Size = new System.Drawing.Size(98, 23);
			this.settingButton.TabIndex = 1;
			this.settingButton.Text = "Settings";
			this.settingButton.UseVisualStyleBackColor = true;
			this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
			// 
			// TabManager
			// 
			this.TabManager.Controls.Add(this.tabPageSunday);
			this.TabManager.Controls.Add(this.tabPageMonday);
			this.TabManager.Controls.Add(this.tabPageTuesday);
			this.TabManager.Controls.Add(this.tabPageWednesday);
			this.TabManager.Controls.Add(this.tabPageThursday);
			this.TabManager.Controls.Add(this.tabPageFriday);
			this.TabManager.Controls.Add(this.tabPageSaturday);
			this.TabManager.Location = new System.Drawing.Point(12, 136);
			this.TabManager.Name = "TabManager";
			this.TabManager.SelectedIndex = 0;
			this.TabManager.Size = new System.Drawing.Size(927, 426);
			this.TabManager.TabIndex = 2;
			// 
			// tabPageSunday
			// 
			this.tabPageSunday.Controls.Add(this.listView1);
			this.tabPageSunday.Location = new System.Drawing.Point(4, 22);
			this.tabPageSunday.Name = "tabPageSunday";
			this.tabPageSunday.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageSunday.Size = new System.Drawing.Size(919, 400);
			this.tabPageSunday.TabIndex = 0;
			this.tabPageSunday.Text = "日";
			this.tabPageSunday.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new System.Drawing.Point(3, 3);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(913, 394);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// tabPageMonday
			// 
			this.tabPageMonday.Controls.Add(this.listView2);
			this.tabPageMonday.Location = new System.Drawing.Point(4, 27);
			this.tabPageMonday.Name = "tabPageMonday";
			this.tabPageMonday.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageMonday.Size = new System.Drawing.Size(768, 395);
			this.tabPageMonday.TabIndex = 1;
			this.tabPageMonday.Text = "月";
			this.tabPageMonday.UseVisualStyleBackColor = true;
			// 
			// listView2
			// 
			this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView2.Location = new System.Drawing.Point(3, 3);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(762, 389);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// tabPageTuesday
			// 
			this.tabPageTuesday.Controls.Add(this.listView3);
			this.tabPageTuesday.Location = new System.Drawing.Point(4, 27);
			this.tabPageTuesday.Name = "tabPageTuesday";
			this.tabPageTuesday.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageTuesday.Size = new System.Drawing.Size(768, 395);
			this.tabPageTuesday.TabIndex = 2;
			this.tabPageTuesday.Text = "火";
			this.tabPageTuesday.UseVisualStyleBackColor = true;
			// 
			// listView3
			// 
			this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView3.Location = new System.Drawing.Point(3, 3);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(762, 389);
			this.listView3.TabIndex = 0;
			this.listView3.UseCompatibleStateImageBehavior = false;
			// 
			// tabPageWednesday
			// 
			this.tabPageWednesday.Controls.Add(this.listView4);
			this.tabPageWednesday.Location = new System.Drawing.Point(4, 27);
			this.tabPageWednesday.Name = "tabPageWednesday";
			this.tabPageWednesday.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageWednesday.Size = new System.Drawing.Size(768, 395);
			this.tabPageWednesday.TabIndex = 3;
			this.tabPageWednesday.Text = "水";
			this.tabPageWednesday.UseVisualStyleBackColor = true;
			// 
			// listView4
			// 
			this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView4.Location = new System.Drawing.Point(3, 3);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(762, 389);
			this.listView4.TabIndex = 0;
			this.listView4.UseCompatibleStateImageBehavior = false;
			// 
			// tabPageThursday
			// 
			this.tabPageThursday.Controls.Add(this.listView5);
			this.tabPageThursday.Location = new System.Drawing.Point(4, 27);
			this.tabPageThursday.Name = "tabPageThursday";
			this.tabPageThursday.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageThursday.Size = new System.Drawing.Size(768, 395);
			this.tabPageThursday.TabIndex = 4;
			this.tabPageThursday.Text = "木";
			this.tabPageThursday.UseVisualStyleBackColor = true;
			// 
			// listView5
			// 
			this.listView5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView5.Location = new System.Drawing.Point(3, 3);
			this.listView5.Name = "listView5";
			this.listView5.Size = new System.Drawing.Size(762, 389);
			this.listView5.TabIndex = 0;
			this.listView5.UseCompatibleStateImageBehavior = false;
			// 
			// tabPageFriday
			// 
			this.tabPageFriday.Controls.Add(this.listView6);
			this.tabPageFriday.Location = new System.Drawing.Point(4, 27);
			this.tabPageFriday.Name = "tabPageFriday";
			this.tabPageFriday.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageFriday.Size = new System.Drawing.Size(768, 395);
			this.tabPageFriday.TabIndex = 5;
			this.tabPageFriday.Text = "金";
			this.tabPageFriday.UseVisualStyleBackColor = true;
			// 
			// listView6
			// 
			this.listView6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView6.Location = new System.Drawing.Point(3, 3);
			this.listView6.Name = "listView6";
			this.listView6.Size = new System.Drawing.Size(762, 389);
			this.listView6.TabIndex = 0;
			this.listView6.UseCompatibleStateImageBehavior = false;
			// 
			// tabPageSaturday
			// 
			this.tabPageSaturday.Controls.Add(this.listView7);
			this.tabPageSaturday.Location = new System.Drawing.Point(4, 27);
			this.tabPageSaturday.Name = "tabPageSaturday";
			this.tabPageSaturday.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageSaturday.Size = new System.Drawing.Size(768, 395);
			this.tabPageSaturday.TabIndex = 6;
			this.tabPageSaturday.Text = "土";
			this.tabPageSaturday.UseVisualStyleBackColor = true;
			// 
			// listView7
			// 
			this.listView7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView7.Location = new System.Drawing.Point(3, 3);
			this.listView7.Name = "listView7";
			this.listView7.Size = new System.Drawing.Size(762, 389);
			this.listView7.TabIndex = 0;
			this.listView7.UseCompatibleStateImageBehavior = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(927, 118);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "各曜日タスク残件";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(949, 600);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TabManager);
			this.Controls.Add(this.settingButton);
			this.Controls.Add(this.subscribeButton);
			this.Name = "MainForm";
			this.Text = "Alice";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.TabManager.ResumeLayout(false);
			this.tabPageSunday.ResumeLayout(false);
			this.tabPageMonday.ResumeLayout(false);
			this.tabPageTuesday.ResumeLayout(false);
			this.tabPageWednesday.ResumeLayout(false);
			this.tabPageThursday.ResumeLayout(false);
			this.tabPageFriday.ResumeLayout(false);
			this.tabPageSaturday.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button subscribeButton;
		private System.Windows.Forms.Button settingButton;
		private System.Windows.Forms.TabControl TabManager;
		private System.Windows.Forms.TabPage tabPageSunday;
		private System.Windows.Forms.TabPage tabPageMonday;
		private System.Windows.Forms.TabPage tabPageTuesday;
		private System.Windows.Forms.TabPage tabPageWednesday;
		private System.Windows.Forms.TabPage tabPageThursday;
		private System.Windows.Forms.TabPage tabPageFriday;
		private System.Windows.Forms.TabPage tabPageSaturday;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ListView listView5;
		private System.Windows.Forms.ListView listView6;
		private System.Windows.Forms.ListView listView7;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

