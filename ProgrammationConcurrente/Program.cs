using System;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.IO;

namespace ProgrammationConcurrente
{
    class Program
    {
       
        static string mot = "Lorem";
        static string textFile = @"C:\Users\amine\Desktop\Lab\monText.txt";
        static string texte = read_text();


        static void Main(string[] args)
        {


            Console.WriteLine("main");

            Thread thr1 = new Thread(nbreOccurenceWord);
            Thread thr2 = new Thread(replaceSpaceByAsterisk);
            thr1.Start();
            thr2.Start();



        }


        static void nbreOccurenceWord()
        {
            //Thread.Sleep(6000);// Ficher top voluminueux
            Console.WriteLine("calcul nombre occurences");
            
            int k = 0;
            //var splitted_text = texte.Split("*");
            var splitted_text = texte.Split(" ");
            foreach (var word in splitted_text)
            {
                if (word == mot)
                {
                    k++;

                }
            }
            Console.WriteLine("Le nombre d'occurrences est:" + k);
        }
        static void replaceSpaceByAsterisk()
        {
            Console.WriteLine("remplacement...");
            string new_text = read_text();
            new_text = texte.Replace(" ", "*");
            File.WriteAllText(textFile, new_text);

        }


        static string read_text()
        {


            // Read entire text file content in one string    
            string text = File.ReadAllText(textFile);



            return text;


        }

        


        

    }

    
}
