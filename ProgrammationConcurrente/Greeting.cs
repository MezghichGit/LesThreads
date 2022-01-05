using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
namespace ProgrammationConcurrente
{
    class Greeting
    {
        // static method one
        public static void method1()
        {
       
            for (int I = 0; I <= 10; I++)
            {
                Console.WriteLine("Method1 is : {0}", I);
                // When the value of I is equal to
                if (I == 5)
                {
                    Thread.Sleep(6000); // un temps d'attente(Method1 est bloquée)"
                }
            }
        }

        // static method two
        public static void method2()
        {
            // It prints numbers from 0 to 10
            for (int J = 0; J <= 10; J++)
            {
                Console.WriteLine("Method2 is : {0}", J);
            }
        }
    }
}