using System.IO;

namespace TechVille.IO
{
    public static class FileManager
    {
        public static void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static string ReadFromFile(string path)
        {
            if (!File.Exists(path))
                return string.Empty;

            return File.ReadAllText(path);
        }
    }
}
