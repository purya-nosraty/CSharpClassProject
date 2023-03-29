using System.Linq;
namespace Infrastructure;

public static class MyMessageBox
{
    static MyMessageBox()
    {
    }
    public static DialogResult YesNoMessageBox(string text, string caption)
    {
        var result = System.Windows.Forms.MessageBox.Show(text: text,
           caption: caption, icon: MessageBoxIcon.Question,
           buttons: MessageBoxButtons.YesNo);

        return result;
    }

	public static DialogResult ErrorMessageBox(string text, string caption)
	{
		var result = System.Windows.Forms.MessageBox.Show(text: text,
		   caption: caption, icon: MessageBoxIcon.Error,
		   buttons: MessageBoxButtons.OK);

		return result;
	}

	public static DialogResult ErrorMessageBox(string text)
	{
		var result = System.Windows.Forms.MessageBox.Show(text: text,
		   caption: "Error", icon: MessageBoxIcon.Error,
		   buttons: MessageBoxButtons.OK);

		return result;
	}
}
