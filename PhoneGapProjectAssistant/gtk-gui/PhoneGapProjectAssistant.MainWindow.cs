
// This file has been generated by the GUI designer. Do not modify.
namespace PhoneGapProjectAssistant
{
	public partial class MainWindow
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Label bigLabel;
		
		private global::Gtk.Label greyLabel;
		
		private global::Gtk.HButtonBox hbuttonbox2;
		
		private global::Gtk.Button openButton;
		
		private global::Gtk.Button newButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PhoneGapProjectAssistant.MainWindow
			this.Name = "PhoneGapProjectAssistant.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("PhoneGap Project Assistant");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(10));
			// Container child PhoneGapProjectAssistant.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.bigLabel = new global::Gtk.Label ();
			this.bigLabel.Name = "bigLabel";
			this.bigLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span size=\"xx-large\"><big>No project loaded</big></span>");
			this.bigLabel.UseMarkup = true;
			this.vbox1.Add (this.bigLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.bigLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.greyLabel = new global::Gtk.Label ();
			this.greyLabel.Name = "greyLabel";
			this.greyLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span color=\"#808080\">Create a new project or load an existing one.</span>");
			this.greyLabel.UseMarkup = true;
			this.vbox1.Add (this.greyLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.greyLabel]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.openButton = new global::Gtk.Button ();
			this.openButton.CanFocus = true;
			this.openButton.Name = "openButton";
			this.openButton.UseUnderline = true;
			this.openButton.Label = global::Mono.Unix.Catalog.GetString ("Open project");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-directory", global::Gtk.IconSize.Menu);
			this.openButton.Image = w3;
			this.hbuttonbox2.Add (this.openButton);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.openButton]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.newButton = new global::Gtk.Button ();
			this.newButton.CanFocus = true;
			this.newButton.Name = "newButton";
			this.newButton.UseUnderline = true;
			this.newButton.Label = global::Mono.Unix.Catalog.GetString ("Create new project");
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-new", global::Gtk.IconSize.Menu);
			this.newButton.Image = w5;
			this.hbuttonbox2.Add (this.newButton);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.newButton]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox2]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 567;
			this.DefaultHeight = 112;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.openButton.Clicked += new global::System.EventHandler (this.openButtonClicked);
			this.newButton.Clicked += new global::System.EventHandler (this.newButtonClicked);
		}
	}
}
