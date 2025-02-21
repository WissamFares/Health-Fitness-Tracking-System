using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class StrengthWorkout : Workout
    {
        public int Sets { get; set; }
        public int Reps { get; set; }
        public double WeightLifted { get; set; } // Weight lifted in kilograms or pounds

        // Constructor
        public StrengthWorkout(double duration, int sets, int reps, double weightLifted, DateTime date)
            : base(duration, 0, date) // Initializing base class (calories default to 0 initially)
        {
            Sets = sets;
            Reps = reps;
            WeightLifted = weightLifted;
        }

        // Overriding CalculateCalories Method
        public override double CalculateCalories()
        {
            // Example logic: calories burned is proportional to sets, reps, and weight lifted
            CaloriesBurned = Sets * Reps * WeightLifted * 0.05;
            return CaloriesBurned;
        }
    }
}
