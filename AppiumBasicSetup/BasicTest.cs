﻿using NUnit.Framework;
using System;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using System.Net;

namespace AppiumBasicSetup
{
	[TestFixture()]
	public class BasicTest
	{
		AndroidDriver<AppiumWebElement> driver;

		[SetUp()]
		public void SetUp()
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
			Console.Write("Setting up the test");
			DesiredCapabilities capabilities = new DesiredCapabilities();
			capabilities.SetCapability("testobject_api_key", "YOUR API KEY");
			capabilities.SetCapability("testobject_device", "Samsung_Galaxy_S6_real");
			Uri server = new Uri("http://appium.testobject.com/wd/hub");

			driver = new AndroidDriver<AppiumWebElement>(server, capabilities);
		}

		[Test()]
		public void FirstTest()
		{
			driver.GetScreenshot();
		}

		[TearDown()]
		public void TearDown()
		{
			driver.Quit();
			Console.Write("Tearing down the test");
		}
	}
}
