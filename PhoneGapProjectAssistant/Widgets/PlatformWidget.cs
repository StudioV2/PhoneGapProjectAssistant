using System;
using System.Collections.Generic;

namespace PhoneGapProjectAssistant
{
	public abstract class PlatformWidget : Gtk.Bin
	{
		public virtual string GetPlatformRealName() {
			return "";
		}

		public virtual string GetPlatformName() {
			return "";
		}

		// preference name="String" value="String"
		public abstract Dictionary<String, String> GetPreferences();

		// icon density="String" src="String"
		public abstract Dictionary<String, String> GetPlatformIcons();

		// splash density="String" src="String"
		public abstract Dictionary<String, String> GetPlatformSplashs();

	}
}
