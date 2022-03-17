using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Exercise1
{
    class Program
    {
        //main class
        static void Main(string[] args)
        {
            //filename
            string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"dws.txt");

            //readfile and sort
            sortTextLines(filepath);

            //readfile and reverse sort
            reverseOrderLines(filepath);

            //calculate the text line length
            calculateLength(filepath);

            //Encrypt
            moveChar(filepath);
        }

        //sort text lines
        public static void sortTextLines(string filename)
        {
            if (File.Exists(filename))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }


                // Set a variable to the Documents path.
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write sorted lines to new file
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "DWSFileSort.txt")))
                {
                    //sort lines
                    Array.Sort(lines);

                    //write to new file
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }
                }
            }
        }

        //reverse the order of text file lines
        public static void reverseOrderLines(string filename)
        {

            if (File.Exists(filename))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(filename);

                // Set a variable to the Documents path.
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write sorted lines to new file
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "DWSFileReverseSort.txt")))
                {
                    //sort lines
                    Array.Reverse(lines);

                    //write to new file
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line);
                    }
                }
            }
        }

        //Move each char 20 places
        public static void moveChar(string filename)
        {
            if (File.Exists(filename))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(filename);

                // Set a variable to the Documents path.
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write sorted lines to new file
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "DWSFileASCII.txt")))
                {
                    //write to new file
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(Encoding.ASCII.GetBytes(line));
                    }
                }
            }
        }

        //Calculate the length of the text
        public static void calculateLength(string filename)
        {
            if (File.Exists(filename))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(filename);

                // Set a variable to the Documents path.
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Write sorted lines to new file
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "DWSFileLineLength.txt")))
                {
                    //write to new file
                    foreach (string line in lines)
                    {
                        outputFile.WriteLine(line.Length+" "+line);
                    }
                }
            }
        }
    }
}
