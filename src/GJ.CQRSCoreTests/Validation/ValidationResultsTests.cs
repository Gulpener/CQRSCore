﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GJ.CQRSCore.UnitTests.Validation
{
    [TestClass]
    public class ValidationResultsTests
    {
        [TestMethod]
        public void NotImplemented()
        {
            true.Should().BeFalse();
        }
    }
}