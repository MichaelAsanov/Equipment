using System.IO;
using System.Reflection;

namespace Equipment.UI.Web.IO
{
    public static class EmbeddedFiles
    {
        public static Stream GetStreamFromEmbeddedFile(string embeddedFileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(embeddedFileName);
            return stream;
        }

        public static string GetString(this Stream stream)
        {
            return new StreamReader(stream).ReadToEnd();
        }

        public static string GetFileContent(string fileName)
        {
            return GetStreamFromEmbeddedFile(fileName).GetString();
        }
    }
}
