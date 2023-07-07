using System.ComponentModel;

namespace APlusB
{
    public class SumOfSquares
    {
        public static int SumOfSquaresInteger(int a, int b)
        {
            return A.Add.AddInteger( B.Multiply.MultiplyInteger(a, a), B.Multiply.MultiplyInteger(b, b));
        }
    }
}