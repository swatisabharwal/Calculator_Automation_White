/*
 * Created by SharpDevelop.
 * User: qainfotech
 * Date: 9/19/2017
 * Time: 1:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using System.Diagnostics;

namespace CalculatorDemo
{
	public class SessionInitiator
	{
		[DllImport("user32.dll")]
		static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		Application app;
		
		public WindowsBaseAction baseActions;
		public calculatorActions CalcAction;
		
		public SessionInitiator(string process,string winName)
		{
			_attachApplication(process);
			_initWindows (winName);
		}
		
		private void _initWindows(string winName) {
			CalcAction= new calculatorActions(app,winName);
		}
		
		private void _attachApplication(string process) {
			Process.Start (YamlReader.getData("Application.path"));
			WindowsBaseAction windowBase = new WindowsBaseAction ();
			windowBase.hardWait (3);
			var processes = Process.GetProcessesByName(process);
			app = Application.Attach (processes[0]);
		}

		
			public void launchApplication() {
			app = Application.Launch (YamlReader.getData("Application.path"));
		}

		public void closeSession() {
			app.Close ();
		}
	}
}
