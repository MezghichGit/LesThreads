using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ProgrammationConcurrente
{
    class TestTask
    {
        static void Main(string[] args)
        {
                Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Statred");
                Task task1 = Task.Run(() =>
                {
                    PrintCounter();
                });
                task1.Wait();

                Task task2 = Task.Run(() =>
                {
                    PrintCounter2();
                });
                task2.Wait();
            Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
            Console.ReadKey();
        }
        static void PrintCounter()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            for (int count = 1; count <= 5; count++)
            {
                Console.WriteLine($"count value: {count}");
            }
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed");
        }
        static void PrintCounter2()
        {
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Started");
            for (char count = 'a'; count <= 'e'; count++)
            {
                Console.WriteLine($"count value: {count}");
            }
            Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId }Completed");
        }
    }
}
