using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TryCatch_FileIoExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileIoStatusMessage;
            string data;

            data = ReadData(out fileIoStatusMessage);

            Console.WriteLine();
            Console.WriteLine("File I/O status: {0}", fileIoStatusMessage);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
        }

        static string ReadData(out string fileIOStatusMessage)
        {
            string dataPath = @"Data/Data.txt";
            string data = "";

            try
            {
                data = File.ReadAllText(dataPath);
                fileIOStatusMessage = "Complete";
            }
            catch (DirectoryNotFoundException)
            {
                fileIOStatusMessage = "Unable to locate the folder for the data file.";
            }
            catch(FileNotFoundException)
            {
                fileIOStatusMessage = "Unable to locate the data file.";
            }
            catch(Exception)
            {
                fileIOStatusMessage = "Unable to read data file.";
            }

            return data;
        }
    }
}
