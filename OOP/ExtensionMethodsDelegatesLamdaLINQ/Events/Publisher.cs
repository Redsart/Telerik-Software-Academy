using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public class Publisher
    {
        public delegate void CustomEventHandler(object sender, SampleEvent e);
        public event CustomEventHandler RaiseCustomEvent;

        public void RaiseSampleEvent()
        {
            Console.WriteLine("Event will raise.");
            OnRaisedCustomEvent(new SampleEvent("This is the custom event"));
        }

        protected virtual void OnRaisedCustomEvent(SampleEvent e)
        {
            CustomEventHandler handler = RaiseCustomEvent;

            if (handler !=null)
            {
                e.SampleMessage += String.Format("at {0}",DateTime.Now);
                handler(this, e);
            }
        }
    }
}
