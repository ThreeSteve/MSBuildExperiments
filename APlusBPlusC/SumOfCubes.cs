namespace B
{
    public class SumOfCubesRatio
    {
        public static int SumOfCubesRatioInteger(int a, int b, int c, int d)
        {
            int sum1 = A.Add.AddInteger(B.Multiply.MultiplyInteger(a, a), B.Multiply.MultiplyInteger(b, b));

            int sum2 = A.Add.AddInteger(B.Multiply.MultiplyInteger(c, c), B.Multiply.MultiplyInteger(d, d));

            return C.Divide.DivideInteger(sum1, sum2);
        }
    }
}