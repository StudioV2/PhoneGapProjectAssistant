using System;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace PhoneGapProjectAssistant
{
	public class ShellHelper
	{


		public static Process shellp(string filename, string arguments) 
		{
			var p = new Process();
			p.StartInfo.Arguments = arguments;
			p.StartInfo.CreateNoWindow = true;
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardError = true;
			p.StartInfo.FileName = filename;
			p.Start();
			return p;
		}

		public static String shell (String filename, String arguments = "") {
			var p = shellp(filename, arguments);
			var output = p.StandardOutput.ReadToEnd();
			p.WaitForExit();
			return output;
		}
	}
}