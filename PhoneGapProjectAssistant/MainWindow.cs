using System;
using Gtk;

namespace PhoneGapProjectAssistant
{
	public partial class MainWindow: Gtk.Window
	{
		public MainWindow () : base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void newButtonClicked (object sender, EventArgs e)
		{
			var win = new NewProjectWindow ();
			win.Show ();
			Hide ();
		}

		protected void openButtonClicked (object sender, EventArgs e)
		{
			Gtk.FileChooserDialog f = 
				new Gtk.FileChooserDialog("Choose the directory or project to open",
					this,
					Gtk.FileChooserAction.SelectFolder,
					"Cancel", Gtk.ResponseType.Cancel,
					"Open", Gtk.ResponseType.Accept);
			var ret = f.Run ();
			if (ret == (int)ResponseType.Accept) {
				if (true) {
					var project = new PhoneGapProject (f.Filename);
					if (project.Valid) {
						var win = new PhoneGapProjectManagerWindow (project);
						win.Show ();
						f.Hide ();
						Hide ();
					} else {
						MessageDialog md = new MessageDialog (this, 
							DialogFlags.DestroyWithParent, MessageType.Error, 
							ButtonsType.Close, "This folder doesn't appear to contain a valid PhoneGap project.");
						md.Run();
						md.Destroy();
						f.Hide();
					}
				}
			} else {
				f.Hide ();
			}
		}
	}
}
