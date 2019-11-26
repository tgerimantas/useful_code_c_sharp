using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificationAlgorithmsDataMining1
{
    class Utility
    {
        /// <summary>
        /// Reads a file.
        /// </summary>
        /// <param name="path"> file path</param>
        /// <returns> data </returns>
        public static List<string> ReadFile(string path)
        {
            List<string> data = new List<string>();

            using (var fs = File.OpenRead(path))
            using (var reader = new StreamReader(fs, Encoding.Default))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    data.Add(line);
                }
            }
            return data;
        }
        
    }
}
