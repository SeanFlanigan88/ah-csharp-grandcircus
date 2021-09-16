using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _20210915
{
    class Program
    {
        public static string logFilePath = Path.Combine(Environment.CurrentDirectory, "log");
        public static FileStream logFile;

        static void Main(string[] args)
        {
            SetupLogger();


            for (int i = 0; i < 100; i++)
            {
                Log($"Current Count: {i}\n");
            }

            CloseLogger();
        }

        public static void SetupLogger()
        {
            var sessionID = Guid.NewGuid().ToString();
            logFile = new FileStream($"{logFilePath}-{sessionID}", FileMode.OpenOrCreate);
        }

        public static void CloseLogger()
        {
            logFile.Close();
        }

        public static void Log(string message)
        {
            var byteArr = Encoding.ASCII.GetBytes(message);
            logFile.Write(byteArr, 0, byteArr.Count());
        }

        #region using FileStream with Access

        public static void FileStreamWithAccess()
        {

            var fileName = "secondfile";

            var currentDirectory = Environment.CurrentDirectory;
            //Console.WriteLine(currentDirectory);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Console.WriteLine(desktop);

            var finalPath = Path.Combine(desktop, fileName);
            //Console.WriteLine(finalPath);

            //File.Delete(finalPath);

            var greeting = "hello world";
            var byteArr = Encoding.ASCII.GetBytes(greeting);
            // foreach(var b in byteArr)
            // {
            //     Console.Write(b);
            // }

            using (FileStream fs = new FileStream(finalPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                Console.WriteLine(fs.CanWrite);
                Console.WriteLine(fs.CanRead);
                fs.Write(byteArr);
            }
        }

        #endregion

        #region Using File and FileStreams

        public static void UsingFileAndFileStreams()
        {
            var fileName = "secondfile";

            var currentDirectory = Environment.CurrentDirectory;
            Console.WriteLine(currentDirectory);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine(desktop);

            var finalPath = Path.Combine(desktop, fileName);
            Console.WriteLine(finalPath);

            File.Delete(finalPath);

            var greeting = "hello world";
            var byteArr = Encoding.ASCII.GetBytes(greeting);
            foreach(var b in byteArr)
            {
                Console.Write(b);
            }

            FileStream stream = File.Create(finalPath);
            stream.Write(byteArr, 0, byteArr.Count());
            stream.Close();
        }

        #endregion


        #region Using StreamWriter and StreamReader

        static void WriteAndReadWithStreams()
        {
            List<string> lines = new List<string>()
            {
                "This is line 1",
                "second line",
                "3"
            };

            var fileName = "newfile.txt";

            // var pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // var newDir = Path.Combine(pathToDesktop, "newFolderOne");

            // var directoryInfo = Directory.CreateDirectory(newDir);
            // Console.WriteLine(directoryInfo.FullName);

            // var finalPath = Path.Combine(pathToDesktop, fileName);
            // Console.WriteLine(finalPath);

            using(StreamWriter outputFileStream = new StreamWriter(fileName))
            {
                outputFileStream.WriteLine("Hello");
                lines.ForEach(l => outputFileStream.WriteLine(l));
            }

            using(StreamReader reader = new StreamReader(fileName))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }

                // Console.WriteLine(reader.EndOfStream);
                // var line = reader.ReadLine();
                // Console.WriteLine(line);
                // Console.WriteLine(reader.EndOfStream);

                // line = reader.ReadLine();
                // Console.WriteLine(line);
                // Console.WriteLine(reader.EndOfStream);

                // line = reader.ReadLine();
                // Console.WriteLine(line);
                // Console.WriteLine(reader.EndOfStream);

                // line = reader.ReadLine();
                // Console.WriteLine(line);
                // Console.WriteLine(reader.EndOfStream);

                // line = reader.ReadLine();
                // Console.WriteLine(line);
                // Console.WriteLine(reader.EndOfStream);
            }
        }

        #endregion
    }
}
