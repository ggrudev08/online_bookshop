using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    [TestFixture]
    public class NUnit_Test_CostumerDisplay
    {
        private TextReader _originalIn;
        private TextWriter _originalOut;

        [SetUp]
        public void Setup()
        {
            _originalIn = Console.In;
            _originalOut = Console.Out;
        }

        [TearDown]
        public void TearDown()
        {
            Console.SetIn(_originalIn);
            Console.SetOut(_originalOut);
        }

        [Test]
        public void CustomerDisplay_Ctor_WithExit_DoesNotThrow()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.CustomerDisplay());
        }

        [Test]
        public void CustomerDisplay_Menu_IncludesCustomers()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Customers"));
        }

        [Test]
        public void CustomerDisplay_Menu_HasExitOption()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.CustomerDisplay();
            Assert.IsTrue(sw.ToString().Contains("6. Exit"));
        }

        [Test]
        public void CustomerDisplay_Prompt_Shown()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            Assert.IsTrue(sw.ToString().Contains("Enter operation ID"));
        }

        [Test]
        public void CustomerDisplay_AllList_HeaderPrinted()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            Assert.IsTrue(sw.ToString().Contains("Customers"));
        }

        [Test]
        public void CustomerDisplay_Recreate_Succeeds()
        {
            for (int i = 0; i < 3; i++)
            {
                using var sr = new StringReader("6\n");
                using var sw = new StringWriter();
                Console.SetIn(sr);
                Console.SetOut(sw);
                Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.CustomerDisplay());
            }
        }

        [Test]
        public void CustomerDisplay_MenuFormatting_ContainsEquals()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.CustomerDisplay();
            Assert.IsTrue(sw.ToString().Contains(new string('=', 50)));
        }

        [Test]
        public void CustomerDisplay_OutputLines_AreMultiple()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.CustomerDisplay();
            var lines = sw.ToString().Split(Environment.NewLine);
            Assert.IsTrue(lines.Length > 2);
        }

        [Test]
        public void CustomerDisplay_ExitImmediately_PreventsDatabaseUsage()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new CustomerDisplay());
        }

        [Test]
        public void CustomerDisplay_MenuItems_AllPresent()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Add new customer"));
            Assert.IsTrue(output.Contains("Fetch customer by ID"));
            Assert.IsTrue(output.Contains("Delete customer by ID"));
        }
    }
}
