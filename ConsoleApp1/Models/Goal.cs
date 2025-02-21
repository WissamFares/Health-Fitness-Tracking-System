using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Goal
    {
        public double TargetWeight { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; private set; } // e.g., "In Progress", "Completed"

        // Constructor
        public Goal(double targetWeight, DateTime deadline)
        {
            TargetWeight = targetWeight;
            Deadline = deadline;
            Status = "In Progress";
        }

        // Method to Set Goal
        public void SetGoal(double targetWeight, DateTime deadline)
        {
            TargetWeight = targetWeight;
            Deadline = deadline;
            Status = "In Progress";
        }

        // Method to Check Progress
        public string CheckProgress(double currentWeight)
        {
            if (currentWeight <= TargetWeight)
            {
                Status = "Completed";
                return "Congratulations! You have achieved your goal.";
            }
            else if (DateTime.Now > Deadline)
            {
                Status = "Failed";
                return "Deadline passed. Goal not achieved.";
            }
            else
            {
                return $"Keep going! Current weight: {currentWeight}, Target weight: {TargetWeight}, Days remaining: {(Deadline - DateTime.Now).Days}";
            }
        }
    }
}
