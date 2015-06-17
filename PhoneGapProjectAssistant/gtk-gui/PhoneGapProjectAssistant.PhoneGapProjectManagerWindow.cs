
// This file has been generated by the GUI designer. Do not modify.
namespace PhoneGapProjectAssistant
{
	public partial class PhoneGapProjectManagerWindow
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label nameLabel;
		
		private global::Gtk.Label pathLabel;
		
		private global::Gtk.Fixed fixed3;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.ComboBox platformCombobox;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.Entry versionEntry;
		
		private global::Gtk.Button button157;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Entry idEntry;
		
		private global::Gtk.HBox hbox4;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Entry nameEntry;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Entry descriptionEntry;
		
		private global::Gtk.HBox hbox7;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Entry authorEntry;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Entry emailEntry;
		
		private global::Gtk.HBox hbox9;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.Entry websiteEntry;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Entry originEntry;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Entry sourceEntry;
		
		private global::Gtk.Notebook platformNotebook;
		
		private global::Gtk.HButtonBox hbuttonbox1;
		
		private global::Gtk.Button button619;
		
		private global::Gtk.Button button163;
		
		private global::Gtk.Button button164;
		
		private global::Gtk.Button button165;
		
		private global::Gtk.Button button166;
		
		private global::Gtk.HButtonBox hbuttonbox2;
		
		private global::Gtk.Button button158;
		
		private global::Gtk.Button button159;
		
		private global::Gtk.Button button125;
		
		private global::Gtk.Button button160;
		
		private global::Gtk.Button button161;
		
		private global::Gtk.Button button162;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget PhoneGapProjectAssistant.PhoneGapProjectManagerWindow
			this.Name = "PhoneGapProjectAssistant.PhoneGapProjectManagerWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("PhoneGapProjectManagerWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.BorderWidth = ((uint)(3));
			// Container child PhoneGapProjectAssistant.PhoneGapProjectManagerWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.nameLabel = new global::Gtk.Label ();
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
			this.hbox1.Add (this.nameLabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.nameLabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.pathLabel = new global::Gtk.Label ();
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
			this.hbox1.Add (this.pathLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.pathLabel]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.hbox1.Add (this.fixed3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fixed3]));
			w3.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Target:");
			this.hbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.platformCombobox = global::Gtk.ComboBox.NewText ();
			this.platformCombobox.Name = "platformCombobox";
			this.hbox1.Add (this.platformCombobox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.platformCombobox]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Version:");
			this.hbox1.Add (this.label4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label4]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			// Container child alignment1.Gtk.Container+ContainerChild
			this.versionEntry = new global::Gtk.Entry ();
			this.versionEntry.WidthRequest = 45;
			this.versionEntry.CanFocus = true;
			this.versionEntry.Name = "versionEntry";
			this.versionEntry.IsEditable = true;
			this.versionEntry.InvisibleChar = '●';
			this.alignment1.Add (this.versionEntry);
			this.hbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment1]));
			w8.Position = 6;
			w8.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button157 = new global::Gtk.Button ();
			this.button157.CanFocus = true;
			this.button157.Name = "button157";
			this.button157.UseUnderline = true;
			this.button157.Label = global::Mono.Unix.Catalog.GetString ("Rebuild");
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Menu);
			this.button157.Image = w9;
			this.hbox1.Add (this.button157);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button157]));
			w10.Position = 7;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator1]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Id:");
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.idEntry = new global::Gtk.Entry ();
			this.idEntry.CanFocus = true;
			this.idEntry.Name = "idEntry";
			this.idEntry.IsEditable = true;
			this.idEntry.InvisibleChar = '●';
			this.hbox2.Add (this.idEntry);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.idEntry]));
			w14.Position = 1;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.hbox4.Add (this.label7);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label7]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.nameEntry = new global::Gtk.Entry ();
			this.nameEntry.CanFocus = true;
			this.nameEntry.Name = "nameEntry";
			this.nameEntry.IsEditable = true;
			this.nameEntry.InvisibleChar = '●';
			this.hbox4.Add (this.nameEntry);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.nameEntry]));
			w17.Position = 1;
			this.vbox1.Add (this.hbox4);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
			w18.Position = 3;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Description:");
			this.hbox5.Add (this.label8);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label8]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.descriptionEntry = new global::Gtk.Entry ();
			this.descriptionEntry.CanFocus = true;
			this.descriptionEntry.Name = "descriptionEntry";
			this.descriptionEntry.IsEditable = true;
			this.descriptionEntry.InvisibleChar = '●';
			this.hbox5.Add (this.descriptionEntry);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.descriptionEntry]));
			w20.Position = 1;
			this.vbox1.Add (this.hbox5);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
			w21.Position = 4;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Author:");
			this.hbox7.Add (this.label10);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label10]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.authorEntry = new global::Gtk.Entry ();
			this.authorEntry.CanFocus = true;
			this.authorEntry.Name = "authorEntry";
			this.authorEntry.IsEditable = true;
			this.authorEntry.InvisibleChar = '●';
			this.hbox7.Add (this.authorEntry);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.authorEntry]));
			w23.Position = 1;
			this.vbox1.Add (this.hbox7);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox7]));
			w24.Position = 5;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Email:");
			this.hbox8.Add (this.label11);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label11]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.emailEntry = new global::Gtk.Entry ();
			this.emailEntry.CanFocus = true;
			this.emailEntry.Name = "emailEntry";
			this.emailEntry.IsEditable = true;
			this.emailEntry.InvisibleChar = '●';
			this.hbox8.Add (this.emailEntry);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.emailEntry]));
			w26.Position = 1;
			this.vbox1.Add (this.hbox8);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox8]));
			w27.Position = 6;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Website:");
			this.hbox9.Add (this.label12);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label12]));
			w28.Position = 0;
			w28.Expand = false;
			w28.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.websiteEntry = new global::Gtk.Entry ();
			this.websiteEntry.CanFocus = true;
			this.websiteEntry.Name = "websiteEntry";
			this.websiteEntry.IsEditable = true;
			this.websiteEntry.InvisibleChar = '●';
			this.hbox9.Add (this.websiteEntry);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.websiteEntry]));
			w29.Position = 1;
			this.vbox1.Add (this.hbox9);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox9]));
			w30.Position = 7;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Origin:");
			this.hbox3.Add (this.label2);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label2]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.originEntry = new global::Gtk.Entry ();
			this.originEntry.CanFocus = true;
			this.originEntry.Name = "originEntry";
			this.originEntry.IsEditable = true;
			this.originEntry.InvisibleChar = '●';
			this.hbox3.Add (this.originEntry);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.originEntry]));
			w32.Position = 1;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w33.Position = 8;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Source:");
			this.hbox6.Add (this.label6);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label6]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.sourceEntry = new global::Gtk.Entry ();
			this.sourceEntry.CanFocus = true;
			this.sourceEntry.Name = "sourceEntry";
			this.sourceEntry.IsEditable = true;
			this.sourceEntry.InvisibleChar = '●';
			this.hbox6.Add (this.sourceEntry);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.sourceEntry]));
			w35.Position = 1;
			this.vbox1.Add (this.hbox6);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox6]));
			w36.Position = 9;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.platformNotebook = new global::Gtk.Notebook ();
			this.platformNotebook.CanFocus = true;
			this.platformNotebook.Name = "platformNotebook";
			this.platformNotebook.CurrentPage = -1;
			this.platformNotebook.Scrollable = true;
			this.platformNotebook.BorderWidth = ((uint)(3));
			this.vbox1.Add (this.platformNotebook);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.platformNotebook]));
			w37.Position = 10;
			w37.Padding = ((uint)(2));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			this.hbuttonbox1.Name = "hbuttonbox1";
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button619 = new global::Gtk.Button ();
			this.button619.CanFocus = true;
			this.button619.Name = "button619";
			this.button619.UseUnderline = true;
			this.button619.Label = global::Mono.Unix.Catalog.GetString ("Update config");
			global::Gtk.Image w38 = new global::Gtk.Image ();
			w38.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
			this.button619.Image = w38;
			this.hbuttonbox1.Add (this.button619);
			global::Gtk.ButtonBox.ButtonBoxChild w39 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.button619]));
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button163 = new global::Gtk.Button ();
			this.button163.CanFocus = true;
			this.button163.Name = "button163";
			this.button163.UseUnderline = true;
			this.button163.Label = global::Mono.Unix.Catalog.GetString ("Clean");
			global::Gtk.Image w40 = new global::Gtk.Image ();
			w40.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-clear", global::Gtk.IconSize.Menu);
			this.button163.Image = w40;
			this.hbuttonbox1.Add (this.button163);
			global::Gtk.ButtonBox.ButtonBoxChild w41 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.button163]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button164 = new global::Gtk.Button ();
			this.button164.CanFocus = true;
			this.button164.Name = "button164";
			this.button164.UseUnderline = true;
			this.button164.Label = global::Mono.Unix.Catalog.GetString ("Build");
			global::Gtk.Image w42 = new global::Gtk.Image ();
			w42.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Menu);
			this.button164.Image = w42;
			this.hbuttonbox1.Add (this.button164);
			global::Gtk.ButtonBox.ButtonBoxChild w43 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.button164]));
			w43.Position = 2;
			w43.Expand = false;
			w43.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button165 = new global::Gtk.Button ();
			this.button165.CanFocus = true;
			this.button165.Name = "button165";
			this.button165.UseUnderline = true;
			this.button165.Label = global::Mono.Unix.Catalog.GetString ("Emulate");
			this.hbuttonbox1.Add (this.button165);
			global::Gtk.ButtonBox.ButtonBoxChild w44 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.button165]));
			w44.Position = 3;
			w44.Expand = false;
			w44.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button166 = new global::Gtk.Button ();
			this.button166.CanFocus = true;
			this.button166.Name = "button166";
			this.button166.UseUnderline = true;
			this.button166.Label = global::Mono.Unix.Catalog.GetString ("Run");
			global::Gtk.Image w45 = new global::Gtk.Image ();
			w45.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-media-play", global::Gtk.IconSize.Menu);
			this.button166.Image = w45;
			this.hbuttonbox1.Add (this.button166);
			global::Gtk.ButtonBox.ButtonBoxChild w46 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.button166]));
			w46.Position = 4;
			w46.Expand = false;
			w46.Fill = false;
			this.vbox1.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox1]));
			w47.Position = 11;
			w47.Expand = false;
			w47.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.Spacing = 10;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button158 = new global::Gtk.Button ();
			this.button158.CanFocus = true;
			this.button158.Name = "button158";
			this.button158.UseUnderline = true;
			this.button158.Label = global::Mono.Unix.Catalog.GetString ("Close");
			global::Gtk.Image w48 = new global::Gtk.Image ();
			w48.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-close", global::Gtk.IconSize.Menu);
			this.button158.Image = w48;
			this.hbuttonbox2.Add (this.button158);
			global::Gtk.ButtonBox.ButtonBoxChild w49 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button158]));
			w49.Expand = false;
			w49.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button159 = new global::Gtk.Button ();
			this.button159.CanFocus = true;
			this.button159.Name = "button159";
			this.button159.UseUnderline = true;
			this.button159.Label = global::Mono.Unix.Catalog.GetString ("Reveal in Finder");
			global::Gtk.Image w50 = new global::Gtk.Image ();
			w50.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-directory", global::Gtk.IconSize.Menu);
			this.button159.Image = w50;
			this.hbuttonbox2.Add (this.button159);
			global::Gtk.ButtonBox.ButtonBoxChild w51 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button159]));
			w51.Position = 1;
			w51.Expand = false;
			w51.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button125 = new global::Gtk.Button ();
			this.button125.CanFocus = true;
			this.button125.Name = "button125";
			this.button125.UseUnderline = true;
			this.button125.Label = global::Mono.Unix.Catalog.GetString ("Open Xcode");
			this.hbuttonbox2.Add (this.button125);
			global::Gtk.ButtonBox.ButtonBoxChild w52 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button125]));
			w52.Position = 2;
			w52.Expand = false;
			w52.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button160 = new global::Gtk.Button ();
			this.button160.CanFocus = true;
			this.button160.Name = "button160";
			this.button160.UseUnderline = true;
			this.button160.Label = global::Mono.Unix.Catalog.GetString ("Manage plugins");
			this.hbuttonbox2.Add (this.button160);
			global::Gtk.ButtonBox.ButtonBoxChild w53 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button160]));
			w53.Position = 3;
			w53.Expand = false;
			w53.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button161 = new global::Gtk.Button ();
			this.button161.CanFocus = true;
			this.button161.Name = "button161";
			this.button161.UseUnderline = true;
			this.button161.Label = global::Mono.Unix.Catalog.GetString ("Splash and icons");
			this.hbuttonbox2.Add (this.button161);
			global::Gtk.ButtonBox.ButtonBoxChild w54 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button161]));
			w54.Position = 4;
			w54.Expand = false;
			w54.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.button162 = new global::Gtk.Button ();
			this.button162.CanFocus = true;
			this.button162.Name = "button162";
			this.button162.UseUnderline = true;
			this.button162.Label = global::Mono.Unix.Catalog.GetString ("Edit config.xml");
			this.hbuttonbox2.Add (this.button162);
			global::Gtk.ButtonBox.ButtonBoxChild w55 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.button162]));
			w55.Position = 5;
			w55.Expand = false;
			w55.Fill = false;
			this.vbox1.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox2]));
			w56.Position = 12;
			w56.Expand = false;
			w56.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 830;
			this.DefaultHeight = 664;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.button157.Clicked += new global::System.EventHandler (this.RebuildPlatformClicked);
			this.button619.Clicked += new global::System.EventHandler (this.UpdateClicked);
			this.button163.Clicked += new global::System.EventHandler (this.CleanClicked);
			this.button164.Clicked += new global::System.EventHandler (this.BuildClicked);
			this.button165.Clicked += new global::System.EventHandler (this.EmulateClicked);
			this.button166.Clicked += new global::System.EventHandler (this.RunClicked);
			this.button158.Clicked += new global::System.EventHandler (this.OnCloseClicked);
			this.button159.Clicked += new global::System.EventHandler (this.OpenInFinder);
			this.button125.Clicked += new global::System.EventHandler (this.OpenXCodeClicked);
		}
	}
}
