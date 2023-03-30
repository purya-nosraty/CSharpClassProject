namespace MyApplication;

internal static class Program
{
	[STAThread]
	static void Main()
	{
		// **************************************************
		var mainForm = new MainForm();

		System.Windows.Forms.Application.Run(mainForm: mainForm);

		if (mainForm != null)
		{
			if (mainForm.IsDisposed == false)
			{
				mainForm.Dispose();
			}
		}
		// **************************************************
	}
}