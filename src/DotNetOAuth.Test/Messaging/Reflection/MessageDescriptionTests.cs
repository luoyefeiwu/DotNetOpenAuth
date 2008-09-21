﻿//-----------------------------------------------------------------------
// <copyright file="MessageDescriptionTests.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOAuth.Test.Messaging.Reflection {
	using System;
	using DotNetOAuth.Messaging.Reflection;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class MessageDescriptionTests : MessagingTestBase {
		[TestMethod, ExpectedException(typeof(ArgumentNullException))]
		public void GetNull() {
			MessageDescription.Get(null);
		}

		[TestMethod, ExpectedException(typeof(ArgumentException))]
		public void GetNonMessageType() {
			MessageDescription.Get(typeof(string));
		}
	}
}
