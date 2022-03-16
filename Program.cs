using System;
using System.IO;

namespace Exercise1
{
    class Program
    {
        //main class
        static void Main(string[] args)
        {
            //filename
            string readerStream = @"C:\dws.txt";
            //FileStream readerStream = new FileStream(@"C:\dws.txt", FileMode.Open);
            sortTextLines(readerStream);
        }

        //sort text lines
        public static void sortTextLines(string filename)
        {
            string[] content = null;
            //read file
            using (StreamReader file = new StreamReader(filename))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    content = file.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }

            //sort
            filename = @"C:\DWSFileSort.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                //Sort the content and write new file
                Array.Sort(content);
                writer.Write(string.Join(Environment.NewLine, content));
            }
        }

        //reverse the order of text file lines
        public static void reverseOrderLines(string filename)
        {

        }

        //Move each char 20 places
        public static void moveChar(string filename)
        {

        }

        //Calculate the length of the text
        public static void calculateLength(string filename)
        {

        }
    }
}
