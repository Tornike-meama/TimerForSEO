using System;
using System.Threading;

namespace TimmerForSEO
{
    internal class Program
    {
        static MyTimer myTimer;
        static void Main(string[] args)
        {
            myTimer = new MyTimer();
            MyTimer.StartTimerEvet += TestTimer;
            myTimer.StartTimer();

            Console.ReadKey();
        }


        public static void TestTimer()
        {
            Console.WriteLine($"timee {myTimer.CurrentTime}");
        }

    }
}
