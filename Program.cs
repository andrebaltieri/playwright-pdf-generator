using Microsoft.Playwright;
using System.Threading.Tasks;

class Program
{
    public static async Task Main()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync();
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://balta.io/blog/linguagens-de-programacao");
        // await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        await page.PdfAsync(new PagePdfOptions { Path = "linguagens-de-programacao.pdf" });
    }
}