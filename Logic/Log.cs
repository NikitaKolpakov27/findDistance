using System;

namespace Logic
{
    public class Log
    {
        public double findDistance(double speed, double course_speed, double time_1, double time_2)
        {
            double Distance = speed * time_1 + (speed - course_speed) * time_2;
            return Distance;
        }
    }
}