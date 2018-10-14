using System;
using System.Windows.Forms;

namespace Alice
{
	/// <summary>
	/// 
	/// </summary>
	public partial class SubscribeWindow : Form
	{
		#region Properties

		/// <summary>
		/// タイトル
		/// </summary>
		public string Title { get; private set; }

		/// <summary>
		/// 話
		/// </summary>
		public int Episode { get; private set; }

		/// <summary>
		/// URL
		/// </summary>
		public string Url { get; private set; }

		/// <summary>
		/// 放映日
		/// </summary>
		public string AirDays { get; private set; }

		#endregion Properties

		#region Constructors

		/// <summary>
		/// SubscribeWindow コンストラクタ
		/// </summary>
		public SubscribeWindow() => this.InitializeComponent();

		#endregion Constructors

		#region Event Handlers

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SubscribeWindow_Load(object sender, EventArgs e)
		{
			this.Title = this.title.Text;
			this.Episode = (int)this.episode.Value;
			this.Url = this.url.Text;
			this.AirDays = this.airDays.Value.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OKButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void airDays_ValueChanged(object sender, EventArgs e)
		{
			this.AirDays = this.airDays.Value.ToString();
		}

		#endregion Event Handlers
	}
}
