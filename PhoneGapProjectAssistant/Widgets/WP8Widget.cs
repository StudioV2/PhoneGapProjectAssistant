using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class WP8Widget : PlatformWidget
	{
		Dictionary<String, String> Preferences = new Dictionary<string, string>();
		Dictionary<String, String> PlatformIcons = new Dictionary<string, string>();
		Dictionary<String, String> PlatformSplashs = new Dictionary<string, string>();

		public WP8Widget ()
		{
			this.Build ();
		}

		public override string GetPlatformRealName() {
			return "Windows Phone";
		}

		public override string GetPlatformName() {
			return "WP8";
		}

		public override Dictionary<String, String> GetPreferences() {
			return Preferences;
		}

		public override Dictionary<String, String> GetPlatformIcons() {
			return PlatformIcons;
		}

		public override Dictionary<String, String> GetPlatformSplashs() {
			return PlatformSplashs;
		}
	}
}

