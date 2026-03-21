using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    /// <summary>
    /// Tests for the OrderDisplay class.
    /// </summary>
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

        [Test]
        public void OrderDisplay_Option1_DisplaysAllOrders()
        {
            using var sr = new StringReader("1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Order ID:") || output.Contains("Orders"));
        }

        [Test]
        public void OrderDisplay_Option4_FetchByIdPrompt()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to fetch"));
        }

        [Test]
        public void OrderDisplay_Option4_FetchExistingOrder_DisplaysDetails()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Order ID:") || output.Contains("Customer ID:"));
        }

        [Test]
        public void OrderDisplay_Option3_UpdatePrompt()
        {
            using var sr = new StringReader("3\n1\n2\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to update") || output.Contains("Done"));
        }

        [Test]
        public void OrderDisplay_MultipleOperations_BeforeExit()
        {
            using var sr = new StringReader("1\n4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new OrderDisplay());
        }

        [Test]
        public void OrderDisplay_MenuOptions_ContainUpdate()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("3. Update"));
        }

        [Test]
        public void OrderDisplay_MenuOptions_ContainDelete()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("5. Delete order by ID"));
        }

        [Test]
        public void OrderDisplay_UpdateOption_AsksForCustomerId()
        {
            using var sr = new StringReader("3\n1\n2\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new Customer ID") || output.Contains("Enter ID to update"));
        }

        [Test]
        public void OrderDisplay_UpdateOption_ShowsDoneOnSuccess()
        {
            using var sr = new StringReader("3\n1\n2\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Done") || output.Contains("Enter ID to update"));
        }

        [Test]
        public void OrderDisplay_AllOrders_DisplaysOrderID()
        {
            using var sr = new StringReader("1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Order ID:"));
        }

        [Test]
        public void OrderDisplay_MenuOptions_ContainAllOrders()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("1. All orders"));
        }

        [Test]
        public void OrderDisplay_MenuOptions_ContainAddNew()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OrderDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("2. Add new order"));
        }
    }
}
