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

		public PlatformWidget() {
			Preferences = new Dictionary<string, string>();
			PlatformIcons = new Dictionary<string, string>();
			PlatformSplashs = new Dictionary<string, string>();
			 
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
			foreach (var kvp in Preferences) {
				var label = new Label ();
				label.Text = kvp.Key;
				var entry = new Entry ();
				entry.Text = kvp.Value;

				var hbox = new HBox ();
				hbox.Add (label);
				hbox.Add (entry);

				hbox.Homogeneous = true;
				preferenceContentVbox.Add (hbox);
			}

			foreach (var kvp in PlatformIcons) {
				var label = new Label ();
				label.Text = kvp.Value;

				iconsVbox.Add (label);
			}

			foreach (var kvp in PlatformSplashs) {
				var label = new Label ();
				label.Text = kvp.Value;

				splashesVbox.Add (label);
			}
		}
	}
}
