using System;
using System.Linq;
using System.Windows.Forms;

namespace MyApplication;

public partial class MainForm : Form
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public MainForm()
	{
		InitializeComponent();
	}
	#endregion /Constructor

	#region ToolStripMenuItem
	#region UpdateProfileForm
	/// <summary>
	/// UpdateProfileForm
	/// </summary>
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
	#endregion /UpdateProfileForm

	#region ChangePasswordForm
	/// <summary>
	/// ChangePasswordForm
	/// </summary>
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
	#endregion /ChangePasswordForm

	#region Logout

	/// <summary>
	/// Logout
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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
	#endregion /Logout

	#region Exit
	/// <summary>
	/// Exit
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
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
	#endregion /Exit
	#endregion /ToolStripMenuItem
}
