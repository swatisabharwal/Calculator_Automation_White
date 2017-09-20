/*
 * Created by SharpDevelop.
 * User: qainfotech
 * Date: 9/19/2017
 * Time: 1:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using TestStack.White.InputDevices;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using System.Windows.Automation;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TableItems;
using  System.Windows.Input;
using TestStack.White;

namespace CalculatorDemo
{
	public class calculatorActionsUI : WindowsBaseAction
	{
		
		WindowsBaseAction windowBase = new WindowsBaseAction ();
	
		public Button get2Button() {
			 return window.Get<Button> (SearchCriteria.ByText("2"));
		}
		
		public Button get3Button() {
			return window.Get<Button> (SearchCriteria.ByText ("3"));
		}
		
		public Button getPlusButton() {
			return window.Get<Button> (SearchCriteria.ByAutomationId("93"));
		}
		
		public Button getEqualsButton() {
				return window.Get<Button> (SearchCriteria.ByText ("Equals"));
		}
		
	}

}
