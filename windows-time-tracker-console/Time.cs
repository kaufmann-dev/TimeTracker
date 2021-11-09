using System;
using System.Timers;

namespace windows_time_tracker_console
{
    public class Time
    {
        //public long TimeInSeconds { get; set; }

        public Time(/*long timeInSeconds*/)
        {
            //this.TimeInSeconds = timeInSeconds;
            SetTime();
        }

        private void SetTime()
        {
            Timer aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                e.SignalTime);
        }
    }
}