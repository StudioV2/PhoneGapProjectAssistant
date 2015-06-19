using Gtk;
using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	[System.ComponentModel.ToolboxItem (true)]
	public abstract partial class PlatformWidget : Gtk.Bin
	{
		public Dictionary<String, String> Preferences;
		public Dictionary<String, String> PlatformIcons;
		public Dictionary<String, String> PlatformSplashs;

		public Dictionary<String, Label> GeneralPreferenceLabels;

		public PlatformWidget() {
			Preferences = new Dictionary<string, string>();
			PlatformIcons = new Dictionary<string, string>();
			PlatformSplashs = new Dictionary<string, string>();

			GeneralPreferenceLabels = new Dictionary<String, Label> ();
			 
			this.Build ();
		}

		public virtual string GetPlatformRealName() {
			return "";
		}

		public virtual string GetPlatformName() {
			return "";
		}

		public virtual string GetPlatformConfigName() {
			return "";
		}

		public virtual void RebuildContent() {
			foreach (var pcvc in preferenceContentVbox.Children) {
				pcvc.Destroy ();
			}
				
			foreach (var ivc in iconsVbox.Children) {
				ivc.Destroy ();
			}

			foreach (var svc in splashesVbox.Children) {
				svc.Destroy ();
			}

			foreach (var kvp in Preferences) {
				GeneralPreferenceLabels[kvp.Value] = new Label ();
				GeneralPreferenceLabels[kvp.Value].Text = kvp.Key;
				var entry = new Entry ();
				entry.Text = kvp.Value;

				var hbox = new HBox ();
				hbox.Add (GeneralPreferenceLabels[kvp.Value]);
				hbox.Add (entry);

				hbox.Homogeneous = true;
				preferenceContentVbox.Add (hbox);
			}

			foreach (var kvp in PlatformIcons) {
				var hbox = new HBox ();
				var img = new Image ();

				try {
					img.Pixbuf = new Gdk.Pixbuf (System.IO.File.ReadAllBytes (kvp.Value));
				} catch (Exception e) {
					System.Console.WriteLine (e);
				}

				hbox.PackStart (img);

				var label = new Label ();
				label.Text = kvp.Value;

				hbox.Add (label);
				hbox.Add (new HBox());
				hbox.Add (new Button ());

				iconsVbox.Add (hbox);
			}

			foreach (var kvp in PlatformSplashs) {
				var label = new Label ();
				label.Text = kvp.Value;

				splashesVbox.Add (label);
			}
		}

		protected void AddIconClicked (object sender, EventArgs e)
		{
			
		}

		protected void AddSplashClicked (object sender, EventArgs e)
		{
			
		}

		public void DestroyGeneralSection() {
			PreferencesTitleBox.Destroy ();
			PreferencesScrolledBox.Destroy ();
		}

		public void DestroyIconsSection() {
			IconsTitleBox.Destroy ();
			IconsScrolledBox.Destroy ();
		}

		public void DestroySplashSection() {
			SplashTitleBox.Destroy ();
			SplashScrolledBox.Destroy ();
		}
	}
}
