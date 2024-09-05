using System;
using System.IO;

namespace MultiPlot
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = Directory.GetCurrentDirectory();

            string csvFolder = Path.Combine(rootPath, "csvs");

            if (!Directory.Exists(csvFolder))
            {
                Console.WriteLine($"The folder 'csvs' does not exist in the root directory: {rootPath}");
                return;
            }

            string[] csvFiles = Directory.GetFiles(csvFolder, "*.csv", SearchOption.AllDirectories);

            if (csvFiles.Length == 0)
            {
                Console.WriteLine("No CSV files found in the 'csvs' folder.");
            }
            else
            {
                Console.WriteLine($"Found {csvFiles.Length} CSV file(s) in the 'csvs' folder:");
                foreach (var file in csvFiles)
                {
                    Console.WriteLine(Path.GetFileName(file));
                }
            }
        }
    }
}
