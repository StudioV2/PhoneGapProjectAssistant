using System;

namespace PhoneGapProjectAssistant
{
	public partial class NewProjectWindow : Gtk.Window
	{
		public NewProjectWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}

		protected void OnClose (object sender, EventArgs e)
		{
			var win = new MainWindow ();
			win.Show ();
			Hide ();
		}

		protected void OnCreate (object sender, EventArgs e)	
		{
			var win = new PhoneGapProjectManagerWindow (new PhoneGapProject ("~/Test"));
			win.Show ();
			Hide ();
		}
	}
}

