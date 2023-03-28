using System.Linq;

namespace MyApplication;

public partial class LoginForm : Infrastructure.BaseForm
{
    #region Constructors
    public LoginForm()
    {
        InitializeComponent();
    }
    #endregion /Constructors

    #region Events
    private void ResetButton_Click(object sender, EventArgs e)
    {
        usernameTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        var result =
            Infrastructure.MyMessageBox.YesNoMessageBox(text: "Are you sure?",
            caption: "Exit");

        if (result == DialogResult.Yes) 
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    #endregion /Events
}
