namespace LeylandExercise.App
{
    public class CustomPerfectSquareCalculator : IPerfectSquareCalculator
    {
        readonly double[] squares = new[]
        {
           1d,
           4d,
           9d,
           16d,
           25d,
           36d,
           49d,
           64d,
           81d,
           100d,
        };

        public bool IsPerfectSquare(int value)
        {
            double leftOver = value;
            while (leftOver > 1)
            {
                var part = squares.Where(v => v <= value).OrderByDescending(v => v).First();
                leftOver -= part;
            }
            return leftOver == 0;
        }
    }
}