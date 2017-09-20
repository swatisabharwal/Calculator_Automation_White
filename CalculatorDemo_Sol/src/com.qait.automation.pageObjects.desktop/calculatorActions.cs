/*
 * Created by SharpDevelop.
 * User: qainfotech
 * Date: 9/19/2017
 * Time: 1:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using TestStack.White;
using TestStack.White.UIItems.TableItems;
using System.Diagnostics;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.Finder;
using NUnit.Framework;
using TestStack.White.Factory;



namespace CalculatorDemo
{

	public class calculatorActions : calculatorActionsUI
	{
			Application app;

		public calculatorActions(Application app, string winName)
		{
			this.app = app;
			window = getWindowHandle (app, winName);
		}
		
		public void addtwonumbersIncalculator()
		{   
			Button btn_two = (Button)get2Button ();
			Console.WriteLine("****btn_two::"+btn_two);
			btn_two.Click();
			string result = btn_two.Text;
			Console.Write(result);
            Assert.AreEqual("2", result, "Sorry Summation is wrong!!");
			Button btn_plus = (Button)getPlusButton ();
			btn_plus.Click();
			Button btn_three = (Button)get3Button ();
			btn_three.Click();
			Button btn_equals = (Button)getEqualsButton ();
			btn_equals.Click();
			
		}
		
		public void closeDispensary()
		{
			foreach (var process in Process.GetProcessesByName("Calculator"))
			{
				process.Kill();
			}
		}
	}
}
