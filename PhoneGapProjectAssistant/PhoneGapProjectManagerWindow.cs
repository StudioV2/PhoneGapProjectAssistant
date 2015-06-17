using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using Gtk;

namespace PhoneGapProjectAssistant
{
	public partial class PhoneGapProjectManagerWindow : Gtk.Window
	{
		// Array of platform specific widgets
		public Dictionary<String, PlatformWidget> platformWidgetsDict;

		protected PhoneGapProject project;
		public PhoneGapProject Project {
			get { return project; }
			set {
				project = value;
				nameLabel.Text = project.Name;
				nameEntry.Text = project.Name;
				pathLabel.Markup = "<span color=\"#808080\">" + project.Path + "</span>";
				descriptionEntry.Text = project.Description;
				versionEntry.Text = project.Version;
				authorEntry.Text = project.Author;
				emailEntry.Text = project.Email;
				websiteEntry.Text = project.Website;
				idEntry.Text = project.Id;
				originEntry.Text = project.Origin;
				sourceEntry.Text = project.Source;
			}
		}

		public PhoneGapProjectManagerWindow (PhoneGapProject project) : base (Gtk.WindowType.Toplevel)
		{
			platformWidgetsDict = new Dictionary<string, PlatformWidget> ();
			foreach (var platformWidget in project.Platforms) {
				platformWidgetsDict.Add (platformWidget.GetPlatformRealName (), platformWidget);
				platformWidget.RebuildContent ();
			}

			Build ();
			Project = project;
			Title = "PhoneGap Project Assistant - " + project.Name;
			int i = 0;
			foreach (var platformWidgetKP in platformWidgetsDict) {
				platformNotebook.AppendPage (platformWidgetKP.Value, new Label(platformWidgetKP.Key));
				platformCombobox.InsertText (i, platformWidgetKP.Value.GetPlatformName());
				i++;
			}
			platformCombobox.Active = 0;
			platformNotebook.ShowAll ();
		}

		protected void UpdateProject() {
			project.Name = nameEntry.Text;
			project.Description = descriptionEntry.Text;
			project.Version = versionEntry.Text;

			project.Version = versionEntry.Text;
			project.Author = authorEntry.Text;
			project.Email = emailEntry.Text;
			project.Website = websiteEntry.Text;
			project.Id = idEntry.Text;
			project.Origin = originEntry.Text;
			project.Source = sourceEntry.Text;

			project.WriteConfig ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnCloseClicked (object sender, EventArgs e)
		{
			var win = new MainWindow ();
			win.Show ();
			Hide ();
		}

		protected void OpenInFinder (object sender, EventArgs e)
		{
			Process.Start(project.Path);
		}

		protected void UpdateClicked (object sender, EventArgs e)
		{
			UpdateProject ();
		}

		protected void CleanClicked (object sender, EventArgs e)
		{
			UpdateProject ();
		}

		protected void BuildClicked (object sender, EventArgs e)
		{
			UpdateProject ();
		}

		protected void EmulateClicked (object sender, EventArgs e)
		{
			UpdateProject ();
		}

		protected void RunClicked (object sender, EventArgs e)
		{
			UpdateProject ();
		}

		protected void RebuildPlatformClicked (object sender, EventArgs e)
		{	
			
			UpdateProject ();
			if (!Directory.Exists (project.Path + "/platforms/" + platformWidgetsDict [platformCombobox.ActiveText].GetPlatformName ())) {
				ShellHelper.shell ("osascript", "-e 'tell app \"Terminal\" to do script \"" + "cd " + project.Path + "; phonegap platform add android ios; exit; killall Terminal" + "\" activate'");
			}
			ShellHelper.shell ("osascript", "-e 'tell app \"Terminal\" to do script \"" + "cd " + project.Path + "; phonegap build; exit; killall Terminal" + "\" activate'");
		}

		protected void OpenXCodeClicked (object sender, EventArgs e)
		{
			ShellHelper.shell ("osascript", "-e 'tell app \"Terminal\" to do script \"" + "open \"" + project.Path + "/platforms/ios/" + project.Name + ".xcodeproj\"; exit; killall Terminal" + "\" activate'");
		}
	}
}
