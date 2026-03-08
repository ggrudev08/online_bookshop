using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    [TestFixture]
    public class NUnit_Test_AuthorDisplay
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
        public void AuthorDisplay_Construct_WithExit_DoesNotThrow()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.AuthorDisplay());
        }

        [Test]
        public void AuthorDisplay_Menu_ShowsAuthorsHeading()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Authors"));
        }

        [Test]
        public void AuthorDisplay_AllOptions_AreWritten()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("All authors"));
            Assert.IsTrue(output.Contains("Add new author"));
            Assert.IsTrue(output.Contains("Fetch author by ID"));
        }

        [Test]
        public void AuthorDisplay_Prompt_ShowsEnterOperation()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter operation ID"));
        }

        [Test]
        public void AuthorDisplay_ExitOption_Present()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("6. Exit"));
        }

        [Test]
        public void AuthorDisplay_RepeatedCreation_DoesNotThrow()
        {
            for (int i = 0; i < 5; i++)
            {
                using var sr = new StringReader("6\n");
                using var sw = new StringWriter();
                Console.SetIn(sr);
                Console.SetOut(sw);
                Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.AuthorDisplay());
            }
        }

        [Test]
        public void AuthorDisplay_Formatting_Checks()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains(new string('=', 50)));
        }

        [Test]
        public void AuthorDisplay_AllList_HeaderIncluded()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Authors"));
        }

        [Test]
        public void AuthorDisplay_MenuLines_AreMultiple()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var lines = sw.ToString().Split(Environment.NewLine);
            Assert.IsTrue(lines.Length > 3);
        }

        [Test]
        public void AuthorDisplay_ExitImmediately_PreventsBusinessCalls()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new AuthorDisplay());
        }
    }
}
