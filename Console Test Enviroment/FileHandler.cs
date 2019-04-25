using System;
using System.Collections.Generic;
using System.IO;

namespace Console_Test_Enviroment
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

}
