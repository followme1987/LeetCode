using System;

namespace MeetingRooms
{
    public class MeetingRooms
    {
        public bool CanAttendMeetings(Interval[] intervals)
        {
            Array.Sort(intervals, (interval, interval1) => interval.Start - interval1.Start);

            for (var i = 0; i < intervals.Length - 1; i++)
                if (intervals[i].End > intervals[i + 1].Start)
                    return false;

            return true;
        }
    }

    public class Interval
    {
        public int End;
        public int Start;

        public Interval()
        {
            Start = 0;
            End = 0;
        }

        public Interval(int s, int e)
        {
            Start = s;
            End = e;
        }
    }
}