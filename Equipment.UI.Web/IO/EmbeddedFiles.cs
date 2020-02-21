using System.IO;
using System.Reflection;
using System.Threading.Tasks;

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
        public static Task<string> GetStringAsync(this Stream stream)
        {
            return new StreamReader(stream).ReadToEndAsync();
        }

        /// <summary>
        /// Returns content of text file by embedded file path
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Task<string> GetFileContentAsync(string fileName)
        {
            return GetStreamFromEmbeddedFile(fileName).GetStringAsync();
        }
    }
}
