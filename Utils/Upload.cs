using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace AppBarganhaWEB.Utils
{
    public class Upload
    {
        public static string UploadArquivo(IWebHostEnvironment webHostEnvironment, IFormFile arquivo, string pasta)
        {
            string wwwwRootPath = webHostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(arquivo.FileName);
            string extension = Path.GetExtension(arquivo.FileName);
            var nomeDoArquivo = fileName + DateTime.Now.ToString("yymmssffff") + extension;
            string path = Path.Combine(wwwwRootPath + "/"+ pasta + "/", nomeDoArquivo);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                arquivo.CopyTo(fileStream);
            }
            return nomeDoArquivo;
        }
    }
}
