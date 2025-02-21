using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1.Interfaces
{
    internal interface IGoalTrackingStrategy
    {
        string EvaluateGoal(User user, Goal goal);
    }
}
