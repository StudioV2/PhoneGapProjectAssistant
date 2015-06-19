using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class WP8Widget : PlatformWidget
	{
		public WP8Widget ()
		{
			Preferences = new Dictionary<string, string>();
			PlatformIcons = new Dictionary<string, string>();
			PlatformSplashs = new Dictionary<string, string>();

			this.Build ();
		}

		public override string GetPlatformRealName() {
			return "Windows Phone";
		}

		public override string GetPlatformName() {
			return "wp8";
		}

		public override string GetPlatformConfigName() {
			return "winphone";
		}

		public override void RebuildContent() {
			base.RebuildContent ();

			DestroyGeneralSection ();
		}
	}
}

