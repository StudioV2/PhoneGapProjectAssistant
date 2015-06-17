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

		public PlatformWidget[] Platforms = {
			new GeneralWidget (), 
			new IOSWidget (),
			new AndroidWidget (),
			new WP8Widget ()
		};

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
				Description = widget["description"].InnerText;
				Author = widget["author"].InnerText;
				Email = widget["author"].Attributes["email"].Value;
				Website = widget["author"].Attributes["href"].Value;
				Origin = widget["access"].Attributes["origin"].Value;
				Source = widget["content"].Attributes["src"].Value;

				foreach(XmlNode subnode in widget.ChildNodes) {
					switch (subnode.Name) {
					case "preference":
						Platforms[0].Preferences[subnode.Attributes["name"].Value] = subnode.Attributes["value"].Value;
						Console.WriteLine("Found global preference: name:" + subnode.Attributes["name"].Value + " value:" + subnode.Attributes["value"].Value); 
						break;
					case "platform":
						foreach(PlatformWidget p in Platforms) {
							if (subnode.Attributes["name"].Value == p.GetPlatformConfigName()) {
								Console.WriteLine("Found " + p.GetPlatformRealName() + " platform node");	
								int i = 0;
								foreach(XmlNode resnode in subnode.ChildNodes) {
									switch (resnode.Name) {
									case "icon":
										Console.WriteLine("  Found icon definition");
										p.PlatformIcons.Add(i.ToString(), resnode.Attributes["src"].Value);
										break;
									case "splash":
										Console.WriteLine("  Found splash definition");
										p.PlatformSplashs.Add(i.ToString(),resnode.Attributes["src"].Value);
										break;
									}
									i++;
								}
							}
						}
						break;
					}
				}
					
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
			} catch (Exception e) {
				Console.WriteLine (e.ToString ());
				valid = false;
			}
			doc.Save(Path + "/" + configFile);
		}
	}
}
