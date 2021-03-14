using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace question38
{
    class Program
    {
       static public async Task ProcessReadAsync()
        {
            try
            {
                string filePath = "C:\\Users\\liron\\Source\\Repos\\multiThreadFinal\\question38\\TextFile.txt";
                if (File.Exists(filePath) != false)
                {
                    string text = await ReadTextAsync(filePath);
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine($"file not found: {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       static private async Task<string> ReadTextAsync(string filePath)
        {
             var sourceStream =
       new FileStream(
           filePath,
           FileMode.Open, FileAccess.Read, FileShare.Read,
           bufferSize: 4096, useAsync: true);


            byte[] buffer = new byte[0x100];
            string text="";
            int numRead;

            while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                text+=Encoding.ASCII.GetString(buffer, 3, numRead);
            }

            return text;

        }

        static void Main(string[] args)
        {
            Task readFile = ProcessReadAsync();
            readFile.Wait();
            Console.ReadLine();
        }
    }
}
