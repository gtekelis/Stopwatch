using System;

namespace stopwatch
{
    public class StopwatchCls
    {

        private DateTime Start { get; set; }
        private DateTime Stop { get; set; }
        private TimeSpan Duration { get; set; }
        private bool IsStarted { get; set; }

        public void Stopwatch()
        {
            this.IsStarted = false;
        }

        public void StartFun()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                Start = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void StopFun()
        {
            if (IsStarted)
            {
                IsStarted = false;
                Stop = DateTime.Now;
                Duration = Stop - Start;

                System.Console.WriteLine($"Stopwatch seconds elapsed: {Duration.Seconds}");             
            }
            else
            {                
                System.Console.WriteLine("Stopwatch is not running");
            }
        }
    }
}