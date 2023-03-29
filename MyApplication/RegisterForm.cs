using Domain;
using System.Linq;


namespace MyApplication;

public partial class RegisterForm : Infrastructure.BaseForm
{
	#region constructor
	public RegisterForm()
	{
		InitializeComponent();
	}
	#endregion /constructor

	#region Events
	#region Reset
	public void Reset()
	{
		usernameTextBox.Text = string.Empty;
		passwordTextBox.Text = string.Empty;
		fullNameTextBox.Text = string.Empty;
	}
	#endregion /Reset

	#region RegisterButton
	private void RegisterButton_Click(object sender, EventArgs e)
	{
		string username = usernameTextBox.Text;
		string password = passwordTextBox.Text;
		string fullName = fullNameTextBox.Text;

		if (username.Length < 6)
		{
			Infrastructure.MyMessageBox
				.ErrorMessageBox(text: "the username must be at least 6 characters");

			return;
		}

		if (password.Length < 8)
		{
			Infrastructure.MyMessageBox
				.ErrorMessageBox(text: "the password must be at least 8 characters");

			return;
		}


		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			var userWithSameUsername =
				databaseContext.Users.
				Where(current => current.Username.ToLower() == username.ToLower())
				.FirstOrDefault();

			if (userWithSameUsername != null)
			{
				Infrastructure.MyMessageBox.ErrorMessageBox(text: "the username already exists!");
				return;
			}

			var user = new User(username: username, password: password)
			{
				FullName = fullName,
			};

			databaseContext.Add(user);
			databaseContext.SaveChanges();

			var message = $" User '{username}' registered successfully.";

			Infrastructure.MyMessageBox.InformationMessageBox(text: message);

			Reset();
		}
		catch (Exception ex)
		{
			var errorMessage =
				$"Error Message: {ex.Message}";

			Infrastructure.MyMessageBox.ErrorMessageBox(text: errorMessage);
		}
		finally
		{
			databaseContext?.Dispose();
		}

	}
	#endregion /RegisterButton

	#region ResetButton
	private void ResetButton_Click(object sender, EventArgs e)
	{
		Reset();
	}
	#endregion /ResetButton

	#region LoginButton
	private void LoginButton_Click(object sender, EventArgs e)
	{

	}
	#endregion /LoginButton

	#region ExitButton
	private void ExitButton_Click(object sender, EventArgs e)
	{
		var result =
					Infrastructure.MyMessageBox.YesNoMessageBox
					(text: "Are you sure?",
					caption: "Exit");

		if (result == DialogResult.Yes)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
	#endregion /ExitButton
	#endregion Events
}
