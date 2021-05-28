using System.IO;

namespace Program2
{
    internal class FileReader
    {
        private StreamReader reader;

        public FileReader(StreamReader reader)
        {
            this.reader = reader;
        }
    }
}