using System.Windows.Forms;

namespace Infrastructure;

public static class Utility : object
{
	static Utility()
	{
	}

	public static string FixText(string? text)
	{
		if (string.IsNullOrEmpty(value: text))
		{
			return string.Empty;
		}

		text =
			text.Trim();

		if (text.Length == 0)
		{
			return string.Empty;
		}

		while (text.Contains(value: "  "))
		{
			text =
				text.Replace
				(oldValue: "  ", newValue: " ");
		}

		return text;
	}

	//public static void ShowMessage ()
	//{
	//	string messageText = string.Empty;
	//	System.Windows.Forms.MessageBox.Show(text: "",
	//		caption: "", icon: MessageBoxIcon.Question, buttons: MessageBoxButtons.YesNo,
	//		defaultButton: MessageBoxDefaultButton.Button2);
	//}
}
