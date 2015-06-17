using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class GeneralWidget : PlatformWidget
	{
		public GeneralWidget ()
		{
			Preferences = new Dictionary<string, string>();
			PlatformIcons = new Dictionary<string, string>();
			PlatformSplashs = new Dictionary<string, string>();

			this.Build ();
		}

		public override string GetPlatformRealName() {
			return "General";
		}

		public override string GetPlatformName() {
			return "*";
		}

		public override void RebuildContent() {
			base.RebuildContent ();
		}
	}
}
