/*
 * Created by SharpDevelop.
 * User: qainfotech
 * Date: 9/19/2017
 * Time: 1:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using TestStack.White;
using System.Drawing;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Factory;
using System.Windows.Automation;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NLog;

namespace CalculatorDemo
{

	public class WindowsBaseAction
	{
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern IntPtr GetForegroundWindow();

		public static Window window;
		private static Logger logger = LogManager.GetCurrentClassLogger();

			public Window getWindowHandle(Application app, String handle){
			return app.GetWindow (handle, InitializeOption.NoCache);
		}

		public void sendKeys(String text) {
			System.Windows.Forms.SendKeys.SendWait (text);
			System.Windows.Forms.SendKeys.SendWait ("{TAB}");
		}

		public void hardWait(int seconds) {
			System.Threading.Thread.Sleep(seconds*1000);
		}

		public void logMessage(String message) {
			logger.Info (message);
		}

		public void moveWindowToTop() {
			IntPtr id;
			id = GetForegroundWindow ();
			MoveWindow (id, 0, 0, 200, 200, true);
		}
	}
}
