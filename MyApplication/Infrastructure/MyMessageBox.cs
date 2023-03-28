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
}
