namespace CShapeAssignmentDay3
{
    public class DisplayClock
    {
        public void ShowClock(object clock, TimeInfoEventArgs timeInfoEvent)
        {
            Console.WriteLine($"{timeInfoEvent.hour}:{timeInfoEvent.minute}:{timeInfoEvent.second}");
        }

        public void Subcribe(Clock clock)
        {
            clock.clockTickEvent += new Clock.clockTickHandler(ShowClock);
        }
    }
}