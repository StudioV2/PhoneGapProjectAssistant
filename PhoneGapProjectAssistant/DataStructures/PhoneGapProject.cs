using System;
using System.IO;
using System.Xml;
using Gtk;

namespace PhoneGapProjectAssistant
{
	public class PhoneGapProject
	{
		protected string configFile = "config.xml";
		protected string wwwDirectory = "www";
		protected string platformsDirectory = "platforms";

		protected bool valid = false;
		public bool Valid {
			get { return File.Exists (Path + "/" + configFile);; }
		}

		public string Name;
		public string Path;
		public string Version;
		public string Id;
		public string Description;
		public string Author;
		public string Email;
		public string Website;
		public string Origin;
		public string Source;

		public PhoneGapProject (string path)
		{
			Path = path;
			if (Valid) {
				ReadConfig ();
			}
		}

		public void ReadConfig() {
			XmlDocument doc = new XmlDocument();
			doc.Load(Path + "/" + configFile);

			try {
				XmlNode widget = doc.GetElementsByTagName("widget")[0];

				Id = widget.Attributes["id"].Value;
				Version = widget.Attributes["version"].Value;

				Name = widget["name"].InnerText;
				Description = widget["description"].InnerText;²&&

				Author = widget["author"].InnerText;
				Email = widget["author"].Attributes["email"].Value;
				Website = widget["author"].Attributes["href"].Value;

				Origin = widget["access"].Attributes["origin"].Value;
				Source = widget["content"].Attributes["src"].Value;
			} catch (Exception e) {
				Console.WriteLine (e.ToString());
				valid = false;
			}
		}

		public void WriteConfig() {
			XmlDocument doc = new XmlDocument();
			doc.Load(Path + "/" + configFile);
			try {
				XmlNode widget = doc.GetElementsByTagName("widget")[0];

				widget.Attributes["id"].Value = Id;
				widget.Attributes["version"].Value = Version;

				widget["name"].InnerText = Name;
				widget["description"].InnerText = Description;

				widget["author"].InnerText = Author;
				widget["author"].Attributes["email"].Value = Email;
				widget["author"].Attributes["href"].Value = Website;

				widget["access"].Attributes["origin"].Value = Origin;
				widget["content"].Attributes["src"].Value = Source;

				foreach(var platform in PhoneGapProjectManagerWindow.platforms) {
					widget["platform"].Attributes["name"].Value = platform.GetPlatformName();
				}

			} catch (Exception e) {
				Console.WriteLine (e.ToString ());
				valid = false;
			}
			doc.Save(Path + "/" + configFile);
		}
	}
}
