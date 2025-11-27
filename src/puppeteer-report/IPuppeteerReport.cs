using PuppeteerSharp;
using System.Threading.Tasks;

namespace PuppeteerReportCsharp
{
    public interface IPuppeteerReport
    {
        Task<byte[]> PDF(string file, PdfOptions? options);
        Task PDF(string file, string outputFile, PdfOptions? options);

        Task<byte[]> PDFPage(IPage page, PdfOptions? options);
        Task PDFPage(IPage page, string outputFile, PdfOptions? options);
    }
}