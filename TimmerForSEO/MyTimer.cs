using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimmerForSEO
{
    internal class MyTimer
    {
        public int CurrentTime { get; private set; }
        public bool IsStartTimer { get; set; } = false;
        public bool IsStopTimer { get; set; } = false;

        public delegate void TimerEvent();

        public static event TimerEvent StartTimerEvet;

        public void StartTimer()
        {
            IsStartTimer = true;
            Task timer = new Task(() => Timer());
            timer.Start();

        }

        private void Timer()
        {
           while(IsStartTimer)
            {
                Thread.Sleep(1000);
                StartTimerEvet();
                IsStopTimer = false;
                CurrentTime++;
            }
        }

        //Task traffTask = new Task(() => TrafficLights());
        //traffTask.Start();
        public void StopTimer()
        {
            IsStopTimer = true;
        }

        public void PauseTimer()
        {
            IsStopTimer = true;
            IsStartTimer = false;
           
            StartTimer();
        }
    }
}
