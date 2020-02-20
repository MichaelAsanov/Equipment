using System.IO;
using System.Reflection;

namespace Equipment.UI.Web.IO
{
    public static class EmbeddedFiles
    {
        public static Stream GetStreamFromEmbeddedFile(string fileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(fileName);
            return stream;
        }

        public static string GetString(this Stream stream)
        {
            return new StreamReader(stream).ReadToEnd();
        }
    }
}
