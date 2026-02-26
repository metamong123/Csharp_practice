using System.Windows;
using System.Windows.Media;

class Program
{
	[STAThread]
	public static void Main()
	{
		Window w = new Window();
		w.Show();

		Application app = new Application();
		app.Run();
	}
}