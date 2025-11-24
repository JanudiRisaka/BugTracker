using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace BugTracker.UITests
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class SmokeTests : PageTest
    {
        // 🚨 REPLACE THIS URL with your specific localhost URL 🚨
        private const string AppUrl = "https://localhost:7051";

        [Test]
        public async Task Homepage_Should_Load_And_Show_Welcome()
        {
            // 1. Arrange & Act: Go to the website
            await Page.GotoAsync(AppUrl);

            // 2. Assert: Check if the title contains "BugTracker"
            // The default title in .NET apps is usually "Home Page - BugTracker.Web"
            await Expect(Page).ToHaveTitleAsync(new Regex("BugTracker"));

            // 3. Assert: Check if the "Welcome" text exists on the page
            await Expect(Page.GetByText("Welcome")).ToBeVisibleAsync();
        }
    }
}