namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{

		}

		private void ChangeFormBackColorbutton_Click(object sender, System.EventArgs e)
		{
			BackColor =
				System.Drawing.Color.FromArgb(180, 200, 50);

			//this.BackColor =
			//	System.Drawing.Color.FromArgb(180, 200, 50);
		}
	}
}
