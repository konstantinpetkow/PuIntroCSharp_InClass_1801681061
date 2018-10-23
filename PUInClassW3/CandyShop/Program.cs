using System;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine;

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"D:\PUWorkFolder\WorkFolderW4\PuIntroCSharp_InClass_1801681061\PUInClassW3\CandyShop\files\Students.txt");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of Students.txt = ");
            int tStudents = 0;
            foreach (string line in lines)
            {
                string[] elements = line.Split(' ');
                string FirstName = elements[1];
                string name = $"{FirstName} {elements[3]}";
                // Use a tab to indent each line of the file.
                //Console.WriteLine("\t" + line);

                int sum = 0;
                for(int i = 0; i<FirstName.Length;i++)

                {
                    sum+= (int)FirstName[i];
                }
                if (sum > 9000)
                {
                    tStudents += 1;
                    Console.WriteLine($"Candy for {name}=>{FirstName.Length}");
                }

            }


            Console.WriteLine($"TOTAL LINES {lines}");
            Console.WriteLine($"Total candy students: {tStudents}");



        }
    }
}
