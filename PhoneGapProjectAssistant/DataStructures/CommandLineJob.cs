using System;
using System.Diagnostics;

namespace PhoneGapProjectAssistant
{
	public class CommandLineJob
	{
		protected String Exec;
		protected String Args;

		public String Command { get { return Exec + " " + Args; } }

		public CommandLineJob (String executable, String arguments)
		{
			Exec = executable;
			Args = arguments;
		}

		public Process Process {
			get {
				/*
				return new Process {
					StartInfo = new ProcessStartInfo {
						FileName = Exec,
						Arguments = Args,
						UseShellExecute = false,
						RedirectStandardOutput = true,
						CreateNoWindow = true
					}
				};
				*/
				var p = new Process ();
				p.StartInfo.Arguments = Args;
				p.StartInfo.CreateNoWindow = true;
				p.StartInfo.UseShellExecute = false;
				p.StartInfo.RedirectStandardOutput = true;
				p.StartInfo.RedirectStandardInput = true;
				p.StartInfo.RedirectStandardError = true;
				p.StartInfo.FileName = Exec;
				p.Start();
				return p;
			}
		}
	}
}

