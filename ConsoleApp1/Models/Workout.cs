using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal abstract class Workout
    {
        public double Duration { get; set; } // Duration in minutes
        public double CaloriesBurned { get; set; }
        public DateTime Date { get; set; }

        // Constructor
        protected Workout(double duration, double caloriesBurned, DateTime date)
        {
            Duration = duration;
            CaloriesBurned = caloriesBurned;
            Date = date;
        }

        // Abstract Method
        public abstract double CalculateCalories();
    }
}
