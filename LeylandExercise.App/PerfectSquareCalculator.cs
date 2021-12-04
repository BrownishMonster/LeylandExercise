using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeylandExercise.App
{
    public class PerfectSquareCalculator : IPerfectSquareCalculator
    {
        public bool IsPerfectSquare(int value)
        {
            var sqrt = Math.Sqrt(value);
            var numerator = Math.Truncate(sqrt);
            return sqrt == numerator;
        }
    }
}
