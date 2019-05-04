using System;
using System.Collections.Generic;
using System.IO;

namespace PeterRG.IO
{
    class FileHandler
    {
        public static Dictionary<int, string[]> LoadMultiLineData(string filePath, MultiLineDataOptions options)
        {
            if (!File.Exists(filePath))
                return null;

            Dictionary<int, string[]> fileData = new Dictionary<int, string[]>();



            return fileData;
        }
    }

    class MultiLineDataOptions
    {
        public int numDataPoints { private set; get; }

        public MultiLineDataOptions(int dataPoints)
        {
            this.numDataPoints = numDataPoints;
        }
    }
}
