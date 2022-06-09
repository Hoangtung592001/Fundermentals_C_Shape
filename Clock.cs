using System;
using System.Threading;
namespace CShapeAssignmentDay3
{
    public class Clock
    {
        private int _hour;

        private int _minute;

        private int _second;

        public delegate void clockTickHandler(object clock, TimeInfoEventArgs timeInfoEvent);

        public event clockTickHandler clockTickEvent;

        public void OnTick(object clock, TimeInfoEventArgs timeInfoEvent)
        {
            if (clockTickEvent != null)
            {
                clockTickEvent(clock, timeInfoEvent);
            }
        }

        public void Run()
        {
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(1000);
                DateTime now = DateTime.Now;
                if (now.Second != this._second)
                {
                    TimeInfoEventArgs timeInfoEvent = new TimeInfoEventArgs(now.Hour, now.Minute, now.Second);
                    OnTick(this, timeInfoEvent);
                }
            }
        }
    }
}