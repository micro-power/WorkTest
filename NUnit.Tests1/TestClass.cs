﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;


namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
        [Test]
        public void TestMethod2()
        {
            int a = 5;
            a.Should().Be(4);
            // TODO: Add your test code herere
            //Assert.Pass("Your first passing test");
        }
    }
}
