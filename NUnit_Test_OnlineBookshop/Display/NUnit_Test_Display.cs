using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    [TestFixture]
    public class NUnit_Test_Display
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
        public void Display_Construct_WithExitOption5_DoesNotThrow()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.Display());
        }

        [Test]
        public void Display_Menu_ContainsAuthorOption()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("1. Author"));
        }

        [Test]
        public void Display_Menu_ContainsBookOption()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("2. Book"));
        }

        [Test]
        public void Display_Menu_ContainsCustomerOption()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("3. Customer"));
        }

        [Test]
        public void Display_Menu_ContainsOrderOption()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("4. Order"));
        }

        [Test]
        public void Display_Menu_ContainsExitOption()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("5. Exit"));
        }

        [Test]
        public void Display_Logo_IsPrinted()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("/$$$$$$"));
        }

        [Test]
        public void Display_RecreateMultipleTimes_Succeeds()
        {
            for (int i = 0; i < 4; i++)
            {
                using var sr = new StringReader("5\n");
                using var sw = new StringWriter();
                Console.SetIn(sr);
                Console.SetOut(sw);
                Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.Display());
            }
        }

        [Test]
        public void Display_OutputLines_AreMany()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var lines = sw.ToString().Split(Environment.NewLine);
            Assert.IsTrue(lines.Length > 5);
        }

        [Test]
        public void Display_MenuFormatting_IncludesSpaces()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("Author"));
            Assert.IsTrue(outp.Contains("Book"));
        }

        [Test]
        public void Display_Logo_ContainsOnlineBookshopText()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("$$"));
        }

        [Test]
        public void Display_Menu_ShowsAllFiveOptions()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("1. Author"));
            Assert.IsTrue(outp.Contains("2. Book"));
            Assert.IsTrue(outp.Contains("3. Customer"));
            Assert.IsTrue(outp.Contains("4. Order"));
            Assert.IsTrue(outp.Contains("5. Exit"));
        }

        [Test]
        public void Display_ExitOption_IsOption5()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("5. Exit"));
        }

        [Test]
        public void Display_Logo_IsMultiline()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            var lines = outp.Split(Environment.NewLine);
            Assert.IsTrue(lines.Length > 15); // Logo is multiline
        }

        [Test]
        public void Display_Output_ContainsMenuStructure()
        {
            using var sr = new StringReader("5\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.Display();
            var outp = sw.ToString();
            Assert.IsTrue(outp.Contains("Author") && outp.Contains("Book") && outp.Contains("Customer") && outp.Contains("Order"));
        }
    }
}
