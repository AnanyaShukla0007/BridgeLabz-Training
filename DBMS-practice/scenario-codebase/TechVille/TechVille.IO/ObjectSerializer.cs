using System.IO;

namespace TechVille.IO
{
    public static class ObjectSerializer
    {
        public static void Save(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static string Load(string path)
        {
            return File.Exists(path) ? File.ReadAllText(path) : string.Empty;
        }
    }
}
