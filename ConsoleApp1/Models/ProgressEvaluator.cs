using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    internal class ProgressEvaluator
    {
        private readonly IGoalTrackingStrategy _strategy;

        // Constructor
        public ProgressEvaluator(IGoalTrackingStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy), "Strategy cannot be null.");
        }

        // Method to Evaluate Progress
        public string EvaluateProgress(User user, Goal goal)
        {
            if (user == null || goal == null)
            {
                throw new ArgumentNullException("User or Goal cannot be null.");
            }

            return _strategy.EvaluateGoal(user, goal);
        }
    }
}
