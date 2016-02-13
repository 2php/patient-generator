﻿using MARC.HI.EHRS.SVC.Core;
using MohawkCollege.Util.Console.Parameters;
using System;
using System.Diagnostics;
using System.Reflection;
using System.ServiceProcess;

namespace PatientGenerator
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		private static void Main(string[] args)
		{
			// Parser
			ParameterParser<ConsoleParameters> parser = new ParameterParser<ConsoleParameters>();

			// Trace copyright information
			Assembly entryAsm = Assembly.GetEntryAssembly();

			bool hasConsole = true;

			// Dump some info
			Trace.TraceInformation("OpenIZ Startup : v{0}", entryAsm.GetName().Version);
			Trace.TraceInformation("OpenIZ Working Directory : {0}", entryAsm.Location);
			Trace.TraceInformation("Operating System: {0} {1}", Environment.OSVersion.Platform, Environment.OSVersion.VersionString);
			Trace.TraceInformation("CLI Version: {0}", Environment.Version);

			try
			{
				var parameters = parser.Parse(args);

				// What to do?
				if (parameters.ShowHelp)
				{
					parser.WriteHelp(Console.Out);
				}
				else if (parameters.ConsoleMode)
				{
					Console.WriteLine("Patient Generator {0} ({1})", entryAsm.GetName().Version, entryAsm.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion);
					Console.WriteLine("{0}", entryAsm.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright);

					ServiceUtil.Start(typeof(Program).GUID);

					Console.WriteLine("Press [ENTER] to stop...");
					Console.ReadLine();

					ServiceUtil.Stop();
				}
				else
				{
					hasConsole = false;
					ServiceBase[] servicesToRun = new ServiceBase[] { new PatientGenerator() };
					ServiceBase.Run(servicesToRun);
				}
			}
			catch (Exception e)
			{
#if DEBUG
				Trace.TraceError(e.ToString());
				if (hasConsole)
					Console.WriteLine(e.ToString());
#else
                Trace.TraceError("Error encountered: {0}. Will terminate", e.Message);
#endif
			}
		}
	}
}