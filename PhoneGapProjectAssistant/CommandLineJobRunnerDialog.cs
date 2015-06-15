using System;
using System.Diagnostics;

namespace PhoneGapProjectAssistant
{
	public partial class CommandLineJobRunnerDialog : Gtk.Dialog
	{
		protected CommandLineJob Job;

		public CommandLineJobRunnerDialog ()
		{
			this.Build ();
		}

		public void SetCommandLineJob (CommandLineJob job)
		{
			Job = job;
			textviewOutput.Buffer.Text += "[ " + Job.Command + " ]";
		}

		public void Start ()
		{
			var p = Job.Process;
			var output = p.StandardOutput.ReadToEnd ();
			p.WaitForExit ();
			textviewOutput.Buffer.Text += output;
		}

		protected void cancelClick (object sender, EventArgs e)
		{
			Hide();
		}
	}
}

