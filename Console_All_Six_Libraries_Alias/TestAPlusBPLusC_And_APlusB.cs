

public class TestAPlusBPLusC_And_APlusB
{
    public static void Test_1()
    {
        // See https://aka.ms/new-console-template for more information
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("");
        Console.WriteLine("TestAPlusBPLusC_And_APlusB");
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

