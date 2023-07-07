extern alias Fundamental_A;
extern alias Fundamental_B;
extern alias Fundamental_C;
using Fundamental_A::A;
using Fundamental_B::B;
using Fundamental_C::C;

public class TestFundamental_A_B_C
{
    public static void Test_1()
    {
        // See https://aka.ms/new-console-template for more information
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("");
        Console.WriteLine("Fundamental A B C");
        Console.WriteLine("");

        int x = A.Add.AddInteger(1, 2);
        Console.WriteLine("x = 1 + 2 = " + x);

        int y = B.Multiply.MultiplyInteger(x, 2);

        Console.WriteLine(" y = 2x = " + y);

        int z = C.Divide.DivideInteger(y, 3);

        Console.WriteLine(" z = y / 3 = " + z);

        Console.WriteLine("Success");
    }
}

