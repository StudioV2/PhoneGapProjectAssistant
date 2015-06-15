using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class AndroidWidget : PlatformWidget
	{
		Dictionary<String, String> Preferences = new Dictionary<string, string>();
		Dictionary<String, String> PlatformIcons = new Dictionary<string, string>();
		Dictionary<String, String> PlatformSplashs = new Dictionary<string, string>();

		public AndroidWidget ()
		{
			this.Build ();
		}

		public override string GetPlatformRealName() {
			return "Android";
		}

		public override string GetPlatformName() {
			return "android";
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
