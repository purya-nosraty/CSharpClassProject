using System;
using System.Linq;

namespace MyApplication;

public partial class UpdateProfileForm : Infrastructure.BaseForm
{
	#region Constructor
	/// <summary>
	/// Constructor
	/// </summary>
	public UpdateProfileForm()
	{
		InitializeComponent();
	}
	#endregion /Constructor

	#region ResetMethod
	/// <summary>
	/// ResetMethod
	/// </summary>
	private void Reset()
	{
		fullNameTextBox.Text = string.Empty;
		descriptionTextBox.Text = string.Empty;
	}
	#endregion /ResetMethod

	#region FullNameTextBox
	private void FullNameTextBox_TextChanged(object sender, EventArgs e)
	{
		string fullName = fullNameTextBox.Text;
		Infrastructure.Utility.FixText(fullName);
	}
	#endregion /FullNameTextBox

	#region DescriptionTextBox
	private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
	{
		string description = descriptionTextBox.Text;
		Infrastructure.Utility.FixText(description);
	}
	#endregion /DescriptionTextBox

	#region SaveButton
	private void SaveButton_Click(object sender, EventArgs e)
	{
		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			var username =
				Infrastructure.Utility.CurrentUser?.Username;

			if (username != null)
			{
				var foundedUser =
				databaseContext.Users
				.Where(current => current.Username.ToLower() == username.ToLower())
				.FirstOrDefault();
			}
			databaseContext.SaveChanges();
		}

		catch (Exception ex)
		{
			var errorMessage =
				$"ErrorMessage{ex.Message}";

			Infrastructure.MyMessageBox.ErrorMessageBox(errorMessage);
		}

		finally
		{
			databaseContext?.Dispose();
		}
	}
	#endregion SaveButton

	#region ResetButton
	private void ResetButton_Click(object sender, EventArgs e)
	{
		Reset();
	}
	#endregion /ResetButton
}