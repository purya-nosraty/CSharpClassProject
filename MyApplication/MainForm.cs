using System.Linq;


namespace MyApplication;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void OpenToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		var updateProfileForm = new UpdateProfileForm();
		updateProfileForm.Show();

	}

	private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var changePasswordForm = new ChangePasswordForm();
		changePasswordForm.Show();
	}

	private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var result = Infrastructure.MyMessageBox
			.YesNoMessageBox(text: "Are you sure?", caption: "Logout");

		if (result == DialogResult.Yes)
		{
			this.Close();

			var loginForm = new LoginForm();
			loginForm.Show();
		}
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var result =
			Infrastructure.MyMessageBox.YesNoMessageBox
				(text: "Are you sure?", caption: "Exit");

		if (result == DialogResult.Yes)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
