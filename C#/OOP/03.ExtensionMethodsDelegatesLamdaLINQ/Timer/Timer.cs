using System;
using System.Threading;

namespace Timer
{
    class Timer
    {
        public delegate void TimeDlg();
        public TimeDlg SomeMethods { get; set; }
        private int timeInterval;

        public int TimeInterval
        {
            get
            {
                return this.timeInterval;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Interval must be more than 1.");
                }
                this.timeInterval = value;
            }
        }

        public Timer(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public void ExecuteMethods()
        {
            while (true)
        {
            this.SomeMethods();
            Thread.Sleep(this.timeInterval * 1000);
        }
        }
    }
}
