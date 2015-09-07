// Copyright (c) 2015 Eberhard Beilharz
// This software is licensed under the MIT license (http://opensource.org/licenses/MIT)
using System;
using SIL.Utils;
using System.Windows.Forms;

namespace TestingErrorReport
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			//ErrorReporter.ReportException(new ApplicationException("Test"), null, "someone@example.com");
			//ErrorReporter.ReportException(new ApplicationException("Test"), null, "someone@example.com", null, false);
			//ErrorReporter.ReportProblem(null, "someone@example.com", null);
			ErrorReporter.ReportDuplicateGuids(null, "someone@example.com", null, "My error text");
			ErrorReporter.MakeSuggestion(null, "someone@example.com", null);
			Application.Run(new Form());
		}
	}
}
