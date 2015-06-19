using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class IOSWidget : PlatformWidget
	{
		public IOSWidget ()
		{
			Preferences = new Dictionary<string, string>();
			PlatformIcons = new Dictionary<string, string>();
			PlatformSplashs = new Dictionary<string, string>();

			this.Build ();
		}

		public override string GetPlatformRealName() {
			return "iOS";
		}

		public override string GetPlatformName() {
			return "ios";
		}

		public override string GetPlatformConfigName() {
			return "ios";
		}

		public override void RebuildContent() {
			base.RebuildContent ();

			DestroyGeneralSection ();
		}
	}
}
	