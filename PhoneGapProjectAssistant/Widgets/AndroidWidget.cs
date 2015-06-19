using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class AndroidWidget : PlatformWidget
	{
		public AndroidWidget ()
		{
			Preferences = new Dictionary<string, string>();
			PlatformIcons = new Dictionary<string, string>();
			PlatformSplashs = new Dictionary<string, string>();

			this.Build ();
		}

		public override string GetPlatformRealName() {
			return "Android";
		}

		public override string GetPlatformName() {
			return "android";
		}

		public override string GetPlatformConfigName() {
			return "android";
		}

		public override void RebuildContent() {
			base.RebuildContent ();

			DestroyGeneralSection ();
		}
	}
}
	