using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRoomsII
{
    class Program
    {
        /// <summary>
        /// Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] 
        /// find the minimum number of conference rooms required.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            int[] intervals =  { 0, 30, 5, 10, 15, 20 };

            int meetingRooms = FindMinMeetingRooms(intervals);
        }

        private static int FindMinMeetingRooms(int[] intervals)
        {
            if (intervals.Length <= 1)
                return intervals.Length;

            int[] startTimes = new int[intervals.Length];
            int[] endTimes = new int[intervals.Length];

            for(int i=0;i<intervals.Length;i++)
            {
                Interval curr = intervals[i];
                startTimes[i] = curr.start;
                endTimes[i] = curr.end;
            }
            return null;
        }
    }
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }
}
