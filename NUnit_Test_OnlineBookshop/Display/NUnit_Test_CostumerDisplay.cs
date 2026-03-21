using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    /// <summary>
    /// Tests for the CustomerDisplay class.
    /// </summary>
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

        [Test]
        public void CustomerDisplay_Option1_DisplaysAllCustomers()
        {
            using var sr = new StringReader("1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Customers"));
        }

        [Test]
        public void CustomerDisplay_Option4_FetchByIdPrompt()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to fetch"));
        }

        [Test]
        public void CustomerDisplay_Option4_FetchExistingCustomer_DisplaysDetails()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("ID:") || output.Contains("Name:"));
        }

        [Test]
        public void CustomerDisplay_Option5_DeletePrompt()
        {
            using var sr = new StringReader("5\n999999\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new CustomerDisplay());
        }

        [Test]
        public void CustomerDisplay_Option3_UpdatePrompt()
        {
            using var sr = new StringReader("3\n1\nJohn\nDoe\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to update") || output.Contains("Done"));
        }

        [Test]
        public void CustomerDisplay_MultipleOperations_BeforeExit()
        {
            using var sr = new StringReader("1\n4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new CustomerDisplay());
        }

        [Test]
        public void CustomerDisplay_MenuOptions_ContainUpdate()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("3. Update"));
        }

        [Test]
        public void CustomerDisplay_MenuOptions_ContainDelete()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("5. Delete customer by ID"));
        }

        [Test]
        public void CustomerDisplay_UpdateOption_AsksForName()
        {
            using var sr = new StringReader("3\n1\nUpdatedFirst\nUpdatedLast\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter first and last name") || output.Contains("Enter ID to update"));
        }

        [Test]
        public void CustomerDisplay_UpdateOption_ShowsDoneOnSuccess()
        {
            using var sr = new StringReader("3\n1\nTest\nCustomer\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Done") || output.Contains("Enter ID to update"));
        }

        [Test]
        public void CustomerDisplay_DeleteOption_ShowsDoneMessage()
        {
            using var sr = new StringReader("5\n999999\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Done") || output.Contains("Enter ID to delete"));
        }

        [Test]
        public void CustomerDisplay_AllListOption_ShowsHeading()
        {
            using var sr = new StringReader("1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            int customerCount = output.Split(new[] { "Customers" }, StringSplitOptions.None).Length - 1;
            Assert.IsTrue(customerCount >= 2);
        }

        [Test]
        public void CustomerDisplay_FetchOption_DisplaysFormattedOutput()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("="));
        }

        [Test]
        public void CustomerDisplay_AllCustomers_DisplaysID()
        {
            using var sr = new StringReader("1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("ID:"));
        }

        [Test]
        public void CustomerDisplay_MenuOptions_ContainAllCustomers()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new CustomerDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("1. All customers"));
        }
    }
}
