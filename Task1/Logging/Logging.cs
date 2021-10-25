using System;
using System.Collections.Generic;
using System.IO;

namespace Logging
{
    public class Logging
    {
        private static string path = $"D:\\3 курс\\EpamTraining\\logs.txt";
        private StreamWriter streamWriter = new StreamWriter(path, true);
        public void SetLoggs(List<string> movesList)
        {
            foreach(var item in movesList)
            {
                streamWriter.WriteLine(item);
            }
            streamWriter.Close();
        }
    }
}
