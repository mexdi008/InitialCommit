using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Medicio.Utilize
{
    public class FileManager
    {
        public static bool CheckSize(IFormFile file, int kb)
        {
            if (file.Length > kb / 1024) return false;
            return true;
        }
        public static bool CheckType(IFormFile file, string path)
        {
            if (file.ContentType.Contains(path)) return true;
            return false;
        }
        public static string SaveImg(IFormFile file, string savePath)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string fullPath = Path.Combine(savePath, fileName);
            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                file.CopyTo(fs);
            }
            return fileName;
        }

        public static void DeleteImg(string path)
        {
            if (System.IO.File.Exists(path)) System.IO.File.Delete(path);
        }
    }
}
