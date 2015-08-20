using System;

namespace Events
{
    class EventsMain
    {
        static void Main(string[] args)
        {
            Publisher eventPublisher = new Publisher();
            new Subscriber("Pesho", eventPublisher); //create subscribers for the event
            new Subscriber("Gosho", eventPublisher);

            eventPublisher.RaiseSampleEvent(); //sample event is raised by the publisher and handled by the subscribers
        }
    }
}
