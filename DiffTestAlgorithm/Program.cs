using System;
using System.Threading;

namespace DiffTestAlgorithm
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string firstPath = @"E:\test\12.txt";
            string secondPath = @"E:\test\21.txt";
            FileReaderFunc reader = new FileReaderFunc();
            reader.FileReadingStream(firstPath, secondPath);
            Console.ReadKey();
        }
    }
}
