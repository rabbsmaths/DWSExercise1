using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //sort text lines
        [TestMethod]
        public void sortTextLines()
        {
            //filename
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dws.txt");

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
        [TestMethod]
        public  void reverseOrderLines()
        {
            //filename
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dws.txt");

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
        [TestMethod]
        public  void moveChar()
        {
            //filename
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dws.txt");

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
        [TestMethod]
        public  void calculateLength()
        {
            //filename
            string filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "dws.txt");

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
                        outputFile.WriteLine(line.Length + " " + line);
                    }
                }
            }
        }
    }
}
