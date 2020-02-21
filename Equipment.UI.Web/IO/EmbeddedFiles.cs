using System.IO;
using System.Reflection;

namespace Equipment.UI.Web.IO
{
    public static class EmbeddedFiles
    {
        /// <summary>
        /// Returns stream by embedded file path
        /// </summary>
        /// <param name="embeddedFileName"></param>
        /// <returns></returns>
        public static Stream GetStreamFromEmbeddedFile(string embeddedFileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(embeddedFileName);
            return stream;
        }

        /// <summary>
        /// Returns content of text file by stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string GetString(this Stream stream)
        {
            return new StreamReader(stream).ReadToEnd();
        }

        /// <summary>
        /// Returns content of text file by embedded file path
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetFileContent(string fileName)
        {
            return GetStreamFromEmbeddedFile(fileName).GetString();
        }
    }
}
