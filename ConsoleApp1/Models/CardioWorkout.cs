using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class CardioWorkout : Workout
    {
        public double Distance { get; set; } // Distance in kilometers or miles
        public int HeartRate { get; set; } // Average heart rate during workout

        // Constructor
        public CardioWorkout(double duration, double distance, int heartRate, DateTime date)
            : base(duration, 0, date) // Initializing base class (calories default to 0 initially)
        {
            Distance = distance;
            HeartRate = heartRate;
        }

        // Overriding CalculateCalories Method
        public override double CalculateCalories()
        {
            // Example logic: calories burned is proportional to duration and heart rate
            CaloriesBurned = Duration * HeartRate * 0.1;
            return CaloriesBurned;
        }
    }
}
