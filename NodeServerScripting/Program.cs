
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace NodeServerScripting
{
	public class Program
	{
		static void Main(string[] args)
		{
			using (var process = new Process())
			{
				process.StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					CreateNoWindow = true,
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true,
					FileName = AppContext.BaseDirectory + "node.exe",
					Arguments = "server.js"
				};
				process.Start();

				Task.Delay(30000).ConfigureAwait(false).GetAwaiter().GetResult();
				process.Kill();
			}
		}
	}
}
