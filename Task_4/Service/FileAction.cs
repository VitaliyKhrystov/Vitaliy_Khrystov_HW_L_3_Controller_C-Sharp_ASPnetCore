using Microsoft.AspNetCore.Mvc;

namespace Task_4.Service
{
    public static class FileAction
    {
        public static void DownLoad(string path, ControllerBase controllerBase)
        {
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                stream.CopyTo(memory);
            }
            memory.Position = 0;
            var ext = Path.GetExtension(path).ToLowerInvariant();
            controllerBase.File(memory, GetTypes()[ext], Path.GetFileName(path));
        }

        private static Dictionary<string, string> GetTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain" },
                {".pdf", "aplication/pdf" },
                {".docx", "application/vnd.ms-word" },
                {".doc", "application/vnd.ms-word" },
                {".xls", "application/vnd.ms-exel" },
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" }

                //// https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types/Common_types
            };
        }
    }
    
}
