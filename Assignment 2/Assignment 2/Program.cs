using System;
using System.IO;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TxtFiles.Compare(); //Calling the method Comapre;
        }
    }

    class TxtFiles
    {
        static string txt1a = File.ReadAllText(@"GitRepositories_1a.txt"); //Reading the text files 
        static string txt1b = File.ReadAllText(@"GitRepositories_1b.txt");
        static string txt2a = File.ReadAllText(@"GitRepositories_2a.txt");
        static string txt2b = File.ReadAllText(@"GitRepositories_2b.txt");
        static string txt3a = File.ReadAllText(@"GitRepositories_3a.txt");
        static string txt3b = File.ReadAllText(@"GitRepositories_3b.txt");

        public static void Compare()
        {
            if(String.Equals(txt1a, txt1b)) 
            {
                Console.WriteLine($"txt1a and txt1b are not different");//If two of the files are the same then the user is told that the files are the same
            }
            else
            {
                Console.WriteLine($"txt1a and txt1b are different ");//If noth then they are told it is different
            }
            if(String.Equals(txt2a, txt2b))
            {
                Console.WriteLine($"txt2a and txt2b are not different");
            }
            else
            {
                Console.WriteLine($"txt2a and txt2b are different");
            }
            if(String.Equals(txt3a, txt3b))
            {
                Console.WriteLine($"txt3a and txt3b are not different");
            }
            else
            {
                Console.WriteLine($"txt3a and txt3b are different");
            }

        }

       
          

       

    }
}


