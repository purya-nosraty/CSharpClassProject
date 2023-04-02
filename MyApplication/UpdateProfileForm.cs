using System;
using System.Linq;

namespace MyApplication;

public partial class UpdateProfileForm : Infrastructure.BaseForm
{
	public UpdateProfileForm()
	{
		InitializeComponent();
	}

	private void Reset()
	{
		fullNameTextBox.Text = string.Empty;
		descriptionTextBox.Text = string.Empty;
	}

	private void FullNameTextBox_TextChanged(object sender, EventArgs e)
	{
		string fullName = fullNameTextBox.Text;
		Infrastructure.Utility.FixText(fullName);
	}

	private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
	{
		string description = descriptionTextBox.Text;
		Infrastructure.Utility.FixText(description);
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext = 
				new Persistence.DatabaseContext();

			//var foundedUser =
			//	databaseContext.Users.
			//	Where(current => current.Username.ToLower() == this)
			//	.FirstOrDefault();
		}

		catch (Exception)
		{

		}

		finally 
		{

		}
	}

	private void ResetButton_Click(object sender, EventArgs e)
	{
		Reset();
	}
}
