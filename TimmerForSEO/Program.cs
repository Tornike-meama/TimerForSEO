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
            myTimer.StopTimer();
            myTimer.StartTimer();

            Console.Read();
        }


        public static void TestTimer()
        {
            Console.WriteLine($"timee {myTimer.CurrentTime}");
        }

    }
}
