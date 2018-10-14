using Alice.Utility;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alice
{
	/// <summary>
	/// 
	/// </summary>
	public partial class MainForm : Form
	{
		#region Properties

		/// <summary>
		/// 
		/// </summary>
		private string AirDays { get; set; } = string.Empty;

		#endregion Properties

		#region Constructor

		/// <summary>
		/// 
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
		}

		#endregion Constructor

		#region Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			this._Initialize();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void subscribeButton_Click(object sender, EventArgs e)
		{
			var window = new SubscribeWindow();
			if (window.ShowDialog() == DialogResult.OK)
			{
				Console.WriteLine($"タイトル：{window.Title}");
				Console.WriteLine($"話：{window.Episode}");
				Console.WriteLine($"URL：{window.Url}");
				Console.WriteLine($"放映日：{window.AirDays}");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void settingButton_Click(object sender, EventArgs e)
		{

		}

		#endregion Event Handlers

		#region Private methods

		/// <summary>
		/// 
		/// </summary>
		private void _Initialize()
		{
			// ヘッダ情報・ヘッダ幅
			var data = new Dictionary<string, int>()
			{
				{ "タイトル", 300 },
				{ "話", 50 },
				{ "URL", 300 },
				{ "放映日", 150 },
				{ "ステータス", 110 }
			};

			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Sorting = SortOrder.Ascending;
			this.listView1.View = View.Details;

			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.Sorting = SortOrder.Ascending;
			this.listView2.View = View.Details;

			this.listView3.FullRowSelect = true;
			this.listView3.GridLines = true;
			this.listView3.Sorting = SortOrder.Ascending;
			this.listView3.View = View.Details;

			this.listView4.FullRowSelect = true;
			this.listView4.GridLines = true;
			this.listView4.Sorting = SortOrder.Ascending;
			this.listView4.View = View.Details;

			this.listView5.FullRowSelect = true;
			this.listView5.GridLines = true;
			this.listView5.Sorting = SortOrder.Ascending;
			this.listView5.View = View.Details;

			this.listView6.FullRowSelect = true;
			this.listView6.GridLines = true;
			this.listView6.Sorting = SortOrder.Ascending;
			this.listView6.View = View.Details;

			this.listView7.FullRowSelect = true;
			this.listView7.GridLines = true;
			this.listView7.Sorting = SortOrder.Ascending;
			this.listView7.View = View.Details;

			// ヘッダ追加
			foreach (var kvp in data)
			{
				this.listView1.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				this.listView2.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				this.listView3.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				this.listView4.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				this.listView5.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				this.listView6.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
				this.listView7.Columns.Add(ColumnHeaderEx.GetColumnHeader(kvp.Key, kvp.Value));
			}
		}

		#endregion Private methods
	}
}
