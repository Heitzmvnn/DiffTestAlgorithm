using System;
using System.Collections.Generic;
using System.Text;

namespace DiffTestAlgorithm
{
    class RendererFunctions
    {
        static void PreviousStringRenderer(string Target)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(">>>");
            Console.BackgroundColor = default;
            Console.Write(" " + Target + "\n");
            Console.WriteLine();
        }
        static void ClearRenderer(char Target)
        {
            Console.Write(Target);
        }
        static void HeadlineRenderer(char Target)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(Target);
            Console.BackgroundColor = default;
        }
        public void AdditionLineReader(string A)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(">>>");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" " + A);
            Console.WriteLine();
        }
        public void Reader(string A, string B)
        {
            int i = 0;
            int j = 0;

            bool isRepeat = false;
            int count;

            if (A.Length > B.Length)
                count = A.Length;
            else count = B.Length;

            if (A.Contains(B) == true)
            {
                Console.WriteLine("test");
            }

            do
            {
                if (A[i] != B[j])
                {
                    HeadlineRenderer(B[j]);
                    j++;
                }
                else if(A[i] == B[j])
                {
                    
                    ClearRenderer(B[j]);
                    i++;
                    j++;
                }
            }
            while (i < count - 1 && j < count - 1);
            Console.WriteLine();
        }
        
    }
        //public void rsReader(string A, string B)
        //{
        //    bool test = string.IsNullOrWhiteSpace(A);

        //    if (test == true)
        //    {
        //        Console.WriteLine("test");
        //    }
        //    else PreviousStringRenderer(A);

        //    int count;
        //    if (A.Length > B.Length)
        //        count = A.Length;
        //    else count = B.Length;
        //    Console.Write(">>>");
        //    Console.Write(" ");
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (count == A.Length && i < B.Length)
        //        {
        //            if (A[i] != B[i])
        //            {
        //                HeadlineRenderer(B[i]);
        //            }
        //            else ClearRenderer(B[i]);
        //        }
        //        else if (count == B.Length && i < A.Length)
        //        {
        //            if (A[i] != B[i])
        //            {
        //                HeadlineRenderer(B[i]);
        //            }
        //            else ClearRenderer(B[i]);
        //        }
        //        else if (i >= A.Length)
        //        {
        //            HeadlineRenderer(B[i]);
        //        }
        //    }
        //    Console.WriteLine();
        //}
    
}

