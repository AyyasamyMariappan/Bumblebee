﻿using System;

using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

using OpenQA.Selenium;

namespace Bumblebee.IntegrationTests.Shared.Pages
{
	public class GenericTablePage : WebPage
	{
		public GenericTablePage(Session session) : base(session)
		{
		}

		public GenericTablePage(Session session, TimeSpan timeout) : base(session, timeout)
		{
		}

		public ITable Table
		{
			get { return new Table(this, By.Id("DataGrid")); }
		}
	}
}