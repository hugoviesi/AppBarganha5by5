using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace AppBarganhaWEB.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public FileResult MostrarPDF()
        {
            var nomeArquivo = HttpContext.Request.Query["arquivo"];

            string wwwwRootPath = _webHostEnvironment.WebRootPath;

            string path = Path.Combine(wwwwRootPath + "/documentos/" + nomeArquivo);

            var fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            return File(fileStream, "application/pdf");
        }
    }
}