using Microsoft.AspNetCore.Http;
using System.IO;

namespace AppBarganhaWEB.Utils
{
    public class Upload
    {
        public static string UploadFoto(IFormFile pic)
        {
            if (pic != null)
            {
                var fileName = Path.Combine("C:\\foto", Path.GetFileName(pic.FileName));
                using (var fs = new FileStream(fileName, FileMode.Create))
                {
                    pic.CopyTo(fs);
                }

                return "/" + Path.GetFileName(pic.FileName).ToString();
            }
            return null;
        }
    }
}
