extern alias APlusBPlusC_Lib;
using APlusBPlusC_Lib::A;
using APlusBPlusC_Lib::B;
using APlusBPlusC_Lib::C;

public class TestLibs_APlusBPlusC
{
    public static void Test_1()
    {
        // See https://aka.ms/new-console-template for more information
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("");
        Console.WriteLine("Libs TestLibs_APlusBPlusC");
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

