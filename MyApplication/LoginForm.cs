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
    #region Reset
    /// <summary>
    /// Reset
    /// </summary>
    public void Reset()
    {
        usernameTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
    }
    #endregion /Reset
    #region LoginButtun
    private void LoginButton_Click(object sender, EventArgs e)
    {

    }
    #endregion /LoginButtun
    #region ResetButtun
    private void ResetButton_Click(object sender, EventArgs e)
    {
       Reset();
    }
    #endregion /ResetButtun
    #region RegisterButton
    private void RegisterButton_Click(object sender, EventArgs e)
    {

    }
    #endregion /RegisterButton
    #region ExitButton
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
    #endregion /ExitButton
    #endregion /Events
}
