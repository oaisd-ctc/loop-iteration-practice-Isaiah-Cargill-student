
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        // Write1ThroughN_While(5);

        //Write1ThroughN_While(5);

        // WriteNThrough1_While(1);

        //  WriteNThrough1_for(1);

        // WriteEvensThrough100();

        // FindSum(5);

    // FindSumOfEvenNumbers(8);

     // FindSumOfOddNumbers(5);

     OutputRightTriangle(6); 
    }

    public static void Write1ThroughN_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }

        int counter = 1;
        while (counter <= n)

        {
            Console.Write(counter + " ");
            counter++;
        }
        Console.WriteLine("");
    }

    public static void Write1ThroughN_for(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }


        for (int counter = 1; counter <= 5; counter++)
        {
            Console.WriteLine(counter);

        }
    }
    public static void WriteNThrough1_While(int n)
    {
        int counter = 5;
        while (counter >= n)
        {
            Console.WriteLine(counter);
            counter--;
        }

        if (n < 1)
        {
            OutOfRangeMessage(n);
        }



    }
    public static void WriteNThrough1_for(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }


        for (int counter = 1; counter >= 5; counter--)
        {
            Console.WriteLine(counter);

        }

    }
    public static void WriteEvensThrough100()
    {

        for (int counter = 1; counter <= 100; counter++)
        {
            if (counter % 2 != 0)
            {
                continue;
            }
            Console.WriteLine(counter);
        }

    }
    public static void FindSum(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }

        int sum = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            sum = sum + counter;
        }
        Console.WriteLine(sum);

    }

    public static void FindSumOfEvenNumbers(int n)
    {
        
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }

        int sum = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            if (counter % 2 != 0)
            {
                continue;
            }
            sum = sum + counter;
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        for (int counter = 1; counter <= n; counter++)
        {
            if (counter % 2 == 0)
            {
                continue;
            }
            sum = sum + counter;
        }
        Console.WriteLine(sum); 
    }
     public static void OutputRightTriangle(int _base)
     {
        
        for (int i = 1; i <= _base; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
     }
    public static void OutOfRangeMessage(int n)

    {

        Console.WriteLine(n + " is out of range");
    }

}
