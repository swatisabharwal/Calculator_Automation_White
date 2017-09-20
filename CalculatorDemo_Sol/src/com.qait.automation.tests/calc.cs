/*
 * Created by SharpDevelop.
 * User: qainfotech
 * Date: 9/19/2017
 * Time: 1:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using NUnit.Framework;
using System;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;

namespace CalculatorDemo
{
	[TestFixture()]
	public class calc
	{

			SessionInitiator session;
			
			[TestFixtureSetUp()]
			public void init()
			{
				session = new SessionInitiator("calc","Calculator");
			}
			
			[Test()]
			public void Step01_Additon()
			{
				session.CalcAction.addtwonumbersIncalculator();
				
			}
			
			[Test()]
			public void Step10_TearDown()
			{
				session.closeSession();

			}	
		}
}
