using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    [TestFixture]
    public class NUnit_Test_BookDisplay
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
        public void BookDisplay_Construct_WithExitInput_DoesNotThrow()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.BookDisplay());
        }

        [Test]
        public void BookDisplay_MenuContainsBooksHeader()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Books"));
        }

        [Test]
        public void BookDisplay_ShowMenu_WritesSeparators()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains(new string('=', 50)));
        }

        [Test]
        public void BookDisplay_ExitOption_Present()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new OnlineBookshop.Presentation.BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("6. Exit"));
        }

        [Test]
        public void BookDisplay_PromptForOperation_Shown()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter operation ID"));
        }

        [Test]
        public void BookDisplay_MultipleConstructCalls_Work()
        {
            for (int i = 0; i < 3; i++)
            {
                var input = "6" + Environment.NewLine;
                using var sr = new StringReader(input);
                using var sw = new StringWriter();
                Console.SetIn(sr);
                Console.SetOut(sw);

                Assert.DoesNotThrow(() => new OnlineBookshop.Presentation.BookDisplay());
            }
        }

        [Test]
        public void BookDisplay_Output_IncludesAllMenuItems()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("All books"));
            Assert.IsTrue(output.Contains("Add new book"));
            Assert.IsTrue(output.Contains("Fetch book by ID"));
        }

        [Test]
        public void BookDisplay_WhenExitImmediately_NoBusinessCalls()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            // Should not throw; business layer will not be exercised when exit is chosen
            Assert.DoesNotThrow(() => new BookDisplay());
        }

        [Test]
        public void BookDisplay_CanBeCreatedRepeatedlyInSameProcess()
        {
            var input = "6" + Environment.NewLine;
            for (int i = 0; i < 5; i++)
            {
                using var sr = new StringReader(input);
                using var sw = new StringWriter();
                Console.SetIn(sr);
                Console.SetOut(sw);
                new OnlineBookshop.Presentation.BookDisplay();
            }
            Assert.Pass();
        }

        [Test]
        public void BookDisplay_MenuFormatting_IsConsistent()
        {
            var input = "6" + Environment.NewLine;
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

                new OnlineBookshop.Presentation.BookDisplay();
            var output = sw.ToString();
            // Basic formatting checks
            Assert.IsTrue(output.Split(Environment.NewLine).Length > 3);
        }
    }
}
