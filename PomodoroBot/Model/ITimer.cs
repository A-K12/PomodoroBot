using System;
using System.Timers;

namespace PomodoroBot.Model
{
    public interface ITimer
    {
        void RunTimer(Double milliseconds);

        event ElapsedEventHandler Elapsed;
    }
}