
// This file has been generated by the GUI designer. Do not modify.
namespace PhoneGapProjectAssistant
{
	public partial class NewProjectWindow
	{
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.VPaned vpaned2;
		
		private global::Gtk.FileChooserWidget filechooserwidget2;
		
		private global::Gtk.VBox vbox4;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Entry entry2;
		
		private global::Gtk.Fixed fixed5;
		
		private global::Gtk.HButtonBox hbuttonbox3;
		
		private global::Gtk.HButtonBox hbuttonbox4;
		
		private global::Gtk.Button button419;
		
		private global::Gtk.Button button420;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PhoneGapProjectAssistant.NewProjectWindow
			this.Name = "PhoneGapProjectAssistant.NewProjectWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("NewProjectWindow");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(3));
			// Container child PhoneGapProjectAssistant.NewProjectWindow.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vpaned2 = new global::Gtk.VPaned ();
			this.vpaned2.CanFocus = true;
			this.vpaned2.Name = "vpaned2";
			this.vpaned2.Position = 279;
			// Container child vpaned2.Gtk.Paned+PanedChild
			this.filechooserwidget2 = new global::Gtk.FileChooserWidget (((global::Gtk.FileChooserAction)(0)));
			this.filechooserwidget2.Name = "filechooserwidget2";
			this.vpaned2.Add (this.filechooserwidget2);
			global::Gtk.Paned.PanedChild w1 = ((global::Gtk.Paned.PanedChild)(this.vpaned2 [this.filechooserwidget2]));
			w1.Resize = false;
			// Container child vpaned2.Gtk.Paned+PanedChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Project Name:");
			this.hbox3.Add (this.label6);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label6]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry ();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '●';
			this.hbox3.Add (this.entry2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry2]));
			w3.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			this.hbox3.Add (this.fixed5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.fixed5]));
			w4.Position = 2;
			this.vbox4.Add (this.hbox3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox3]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbuttonbox3 = new global::Gtk.HButtonBox ();
			this.hbuttonbox3.Name = "hbuttonbox3";
			this.vbox4.Add (this.hbuttonbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbuttonbox3]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vpaned2.Add (this.vbox4);
			this.vbox5.Add (this.vpaned2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vpaned2]));
			w8.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbuttonbox4 = new global::Gtk.HButtonBox ();
			this.hbuttonbox4.Name = "hbuttonbox4";
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.button419 = new global::Gtk.Button ();
			this.button419.CanFocus = true;
			this.button419.Name = "button419";
			this.button419.UseUnderline = true;
			this.button419.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.button419.Image = w9;
			this.hbuttonbox4.Add (this.button419);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.button419]));
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.button420 = new global::Gtk.Button ();
			this.button420.CanFocus = true;
			this.button420.Name = "button420";
			this.button420.UseUnderline = true;
			this.button420.Label = global::Mono.Unix.Catalog.GetString ("Create");
			global::Gtk.Image w11 = new global::Gtk.Image ();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.button420.Image = w11;
			this.hbuttonbox4.Add (this.button420);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.button420]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox5.Add (this.hbuttonbox4);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbuttonbox4]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.Add (this.vbox5);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 549;
			this.DefaultHeight = 362;
			this.Show ();
			this.button419.Clicked += new global::System.EventHandler (this.OnClose);
			this.button420.Clicked += new global::System.EventHandler (this.OnCreate);
		}
	}
}