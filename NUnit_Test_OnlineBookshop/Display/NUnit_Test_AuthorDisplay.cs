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

        [Test]
        public void AuthorDisplay_Option1_DisplaysAllAuthors()
        {
            using var sr = new StringReader("1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Authors"));
        }

        [Test]
        public void AuthorDisplay_Option4_FetchByIdPrompt()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to fetch"));
        }

        [Test]
        public void AuthorDisplay_Option4_FetchExistingAuthor_DisplaysDetails()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("ID:") || output.Contains("Name:") || output.Contains("Birth year:"));
        }

        [Test]
        public void AuthorDisplay_Option3_UpdatePrompt()
        {
            using var sr = new StringReader("3\n1\nJohn\nDoe\n1990\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter ID to update") || output.Contains("Done"));
        }

        [Test]
        public void AuthorDisplay_MultipleOperations_BeforeExit()
        {
            using var sr = new StringReader("1\n4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            Assert.DoesNotThrow(() => new AuthorDisplay());
        }

        [Test]
        public void AuthorDisplay_MenuOptions_ContainUpdate()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("3. Update"));
        }

        [Test]
        public void AuthorDisplay_MenuOptions_ContainDelete()
        {
            using var sr = new StringReader("6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("5. Delete author by ID"));
        }

        [Test]
        public void AuthorDisplay_FetchOption_DisplaysFormattedOutput()
        {
            using var sr = new StringReader("4\n1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("="));
        }

        [Test]
        public void AuthorDisplay_AllListOption_ShowsHeading()
        {
            using var sr = new StringReader("1\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            // Should show heading with Authors text
            int authorCount = output.Split(new[] { "Authors" }, StringSplitOptions.None).Length - 1;
            Assert.IsTrue(authorCount >= 2); // Menu heading + AllList heading
        }

        [Test]
        public void AuthorDisplay_UpdateOption_AsksForNewFirstName()
        {
            using var sr = new StringReader("3\n1\nUpdatedFirst\nUpdatedLast\n1985\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new first name"));
        }

        [Test]
        public void AuthorDisplay_UpdateOption_AsksForNewLastName()
        {
            using var sr = new StringReader("3\n1\nUpdatedFirst\nUpdatedLast\n1985\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new last name"));
        }

        [Test]
        public void AuthorDisplay_UpdateOption_AsksForNewBirthYear()
        {
            using var sr = new StringReader("3\n1\nUpdatedFirst\nUpdatedLast\n1985\n6\n");
            using var sw = new StringWriter();
            Console.SetIn(sr);
            Console.SetOut(sw);

            new AuthorDisplay();
            var output = sw.ToString();
            Assert.IsTrue(output.Contains("Enter new birth year"));
        }

    }
}
