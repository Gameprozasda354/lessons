using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryFileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.IO
            //CreateNewFolder(@"C:/NewCreatedFolder");
            //CreateNewFolderIfNotExist(@"C:/NewCreatedFolder");
            //DeleteFolder(@"C:/NewCreatedFolder");
            //MoveFolder(@"C:/test", @"C:/to/test");
            //bool fileExists = FileExists(@"C:/test/hello.txt");
            //CreateFile(@"C:/test/salam.txt");
            //MoveFile(@"C:\test\salam.txt", @"C:\to\salam.txt");
            //CopyFile(@"C:\to\salam.txt", @"C:\test\salam.txt");
            //AppendTextToFile(@"C:\to\salam.txt", "Salam necesen?");
            //string text = ReadFileContent(@"C:\to\salam.txt");

            //List<string> countries = new List<string>()
            //{
            //    "Azerbaijan salam",
            //    "Turkey selam",
            //    "Germany hallo",
            //    "Israel hello",
            //    "Italy hello"
            //};
            //AppendMultipleTextsToFile(@"C:\to\salam.txt", countries);

            //string[] countries = ReadFileContentByLine(@"C:\to\salam.txt");
        }

        static void CreateNewFolder(string path)
        {
            DirectoryInfo dirInfo = Directory.CreateDirectory(path);
        }

        static void CreateNewFolderIfNotExist(string path)
        {
            bool checkPath = Directory.Exists(path);

            if (!checkPath)
            {
                DirectoryInfo dirInfo = Directory.CreateDirectory(path);
            }
        }

        static void DeleteFolder(string path)
        {
            Directory.Delete(path, true);
        }

        static void MoveFolder(string source, string destination)
        {
            Directory.Move(source, destination);
        }

        static bool FileExists(string path)
        {
            var isFileExists = File.Exists(path);
            return isFileExists;
        }

        static void CreateFile(string path)
        {
            if (!FileExists(path))
            {
                FileStream fileStream = File.Create(path);
                fileStream.Close();
            }
            else
            {
                Console.WriteLine(path + " fayli artiq movcuddur!");
            }
        }

        static void MoveFile(string from, string to)
        {
            File.Move(from, to);
        }

        static void CopyFile(string from, string to)
        {
            File.Copy(from, to);
        }

        static void AppendTextToFile(string path, string text)
        {
            File.AppendAllText(path, text);
        }

        static string ReadFileContent(string path)
        {
            string content = File.ReadAllText(path);

            return content;
        }

        static void AppendMultipleTextsToFile(string path, List<string> texts)
        {
            File.AppendAllLines(path, texts);
        }

        static string[] ReadFileContentByLine(string path)
        {
            string[] contents = File.ReadAllLines(path);
            return contents;
        }
    }
}
