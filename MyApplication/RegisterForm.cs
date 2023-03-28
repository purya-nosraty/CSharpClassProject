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
    public void Reset () 
    {
        usernameTextBox.Text = string.Empty;
        passwordTextBox.Text = string.Empty;
        fullNameTextBox.Text = string.Empty;
    }
    #endregion /Reset
    #region RegisterButton
    private void RegisterButton_Click(object sender, EventArgs e)
    {

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
