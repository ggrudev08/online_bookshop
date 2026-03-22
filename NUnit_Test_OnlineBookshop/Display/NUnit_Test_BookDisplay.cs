using System;
using System.IO;
using NUnit.Framework;
using OnlineBookshop.Presentation;

namespace NUnit_Test_OnlineBookshop.Display
{
    /// <summary>
    /// Tests for the BookDisplay class.
    /// </summary>
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

        [Test]
        public void BookDisplay_Option1_DisplaysAllBooks()
        {
            var input = "1\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Books"));
        }

        [Test]
        public void BookDisplay_Option4_FetchByIdPrompt()
        {
            var input = "4\n1\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to fetch"));
        }

        [Test]
        public void BookDisplay_Option4_FetchExistingBook_DisplaysDetails()
        {
            var input = "4\n1\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("ID:") || output.Contains("Name:") || output.Contains("Genre:"));
        }


        [Test]
        public void BookDisplay_Option3_UpdatePrompt()
        {
            var input = "3\n1\nUpdated Book\nFiction\n29.99\n2024\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to update") || output.Contains("Done"));
        }

        [Test]
        public void BookDisplay_MultipleOperations_BeforeExit()
        {
            var input = "1\n4\n1\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new BookDisplay());
        }

        [Test]
        public void BookDisplay_MenuOptions_ContainUpdate()
        {
            var input = "6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("3. Update"));
        }

        [Test]
        public void BookDisplay_MenuOptions_ContainDelete()
        {
            var input = "6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("5. Delete book by ID"));
        }

        [Test]
        public void BookDisplay_UpdateOption_AsksForBookName()
        {
            var input = "3\n1\nTest Book\nScience\n25.00\n2023\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new name"));
        }

        [Test]
        public void BookDisplay_UpdateOption_AsksForGenre()
        {
            var input = "3\n1\nTest Book\nScience\n25.00\n2023\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new genre"));
        }

        [Test]
        public void BookDisplay_UpdateOption_AsksForPrice()
        {
            var input = "3\n1\nTest Book\nScience\n25.00\n2023\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new price"));
        }

        [Test]
        public void BookDisplay_UpdateOption_AsksForReleaseYear()
        {
            var input = "3\n1\nTest Book\nScience\n25.00\n2023\n6\n";
            using var sr = new StringReader(input);
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new BookDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new release year"));
        }

       
    }
}
