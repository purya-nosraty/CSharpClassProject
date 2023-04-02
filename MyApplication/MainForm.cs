using System;
using System.Linq;
using System.Windows.Forms;

namespace MyApplication;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private UpdateProfileForm? updateProfileForm { get; set; }

	private void UpdateProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (updateProfileForm == null || updateProfileForm.IsDisposed)
		{
			updateProfileForm = new UpdateProfileForm();

			updateProfileForm.MdiParent = this;
		}

		updateProfileForm.Show();

	}

	private ChangePasswordForm? changePasswordForm { get; set; }

	private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (changePasswordForm == null || changePasswordForm.IsDisposed)
		{
			changePasswordForm = new ChangePasswordForm();

			changePasswordForm.MdiParent = this;
		}

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
