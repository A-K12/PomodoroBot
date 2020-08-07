using System;
using System.Timers;


namespace PomodoroBot.Model
{
    public class PomodoroTimer:ITimer
    {
        public void RunTimer(Double milliseconds)
        {
            Timer timer = new Timer();
            timer.Interval = milliseconds;
            timer.Elapsed += Elapsed;
            timer.Enabled = true;

        }

        public event ElapsedEventHandler Elapsed;

    }
}