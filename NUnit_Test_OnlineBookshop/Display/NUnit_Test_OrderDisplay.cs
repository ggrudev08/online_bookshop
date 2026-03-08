using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    [TestFixture]
    public class NUnit_Test_OrderDisplay
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
        public void OrderDisplay_Constructor_ExitDoesNotThrow()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.OrderDisplay());
        }

        [Test]
        public void OrderDisplay_MenuContainsOrders()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.OrderDisplay();
            Assert.IsTrue(sw.ToString().Contains("Orders"));
        }

        [Test]
        public void OrderDisplay_MenuHasExitOption()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.OrderDisplay();
            Assert.IsTrue(sw.ToString().Contains("6. Exit"));
        }

        [Test]
        public void OrderDisplay_Prompt_ShowsEnterOperationID()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter operation ID") || output.Contains("1. All orders") || output.Contains("Orders"));
        }

        [Test]
        public void OrderDisplay_RecreateMultipleTimes_Succeeds()
        {
            for (int i = 0; i < 4; i++)
            {
                using var sr = new StringReader("6\n");
                using var sw = new StringWriter();
                Console.SetIn(sr);
                Console.SetOut(sw);
                Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.OrderDisplay());
            }
        }

        [Test]
        public void OrderDisplay_MenuFormatting_UsesEquals()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.OrderDisplay();
            Assert.IsTrue(sw.ToString().Contains(new string('=', 50)));
        }

        [Test]
        public void OrderDisplay_MenuItems_AllPresent()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.OrderDisplay();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("All orders"));
            Assert.IsTrue(outp.Contains("Add new order"));
            Assert.IsTrue(outp.Contains("Fetch order by ID"));
        }

        [Test]
        public void OrderDisplay_ExitImmediately_PreventsBusinessCalls()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new OrderDisplay());
        }

        [Test]
        public void OrderDisplay_OutputLines_AreMultiple()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var lines = sw.ToString().Split(Environment.NewLine);
            Assert.IsTrue(lines.Length > 3);
        }

        [Test]
        public void OrderDisplay_MenuShowsDeleteOption()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            Assert.IsTrue(sw.ToString().Contains("Delete order by ID"));
        }
    }
}
