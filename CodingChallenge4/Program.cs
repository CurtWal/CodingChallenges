class Program
{
    public static void Main()
    {
        int[] ay = new int[] { 1, 2, 3 };
        int sum = 0;
        for (int i = 0; i < ay.Length; i++)
        {
            sum += ay[i];
        }
        Console.WriteLine(sum);
        int[] aya = new int[] { 3, 7, 15 };
        int sum1 = 0;
        for (int i = 0; i < aya.Length; i++)
        {
            sum1 += aya[i];
        }
        int[] ayaa = new int[] { 4, 5, 9 };
        int sum2 = 0;
        for (int i = 0; i < ayaa.Length; i++)
        {
            sum2 += aya[i];
        }
        Console.WriteLine(sum2);
        int[] Joined = new int[] { sum, sum1, sum2};
        Console.WriteLine(string.Join(", ", Joined));

        GetNthFibonacci_Ite(9);


    }
    public static int GetNthFibonacci_Ite(int n)
    {
        int number = n - 1; //Need to decrement by 1 since we are starting from 0  
        int[] Fib = new int[number + 1];
        Fib[0] = 0;
        Fib[1] = 1;
        for (int i = 2; i <= number; i++)
        {
            Fib[i] = Fib[i - 2] + Fib[i - 1];
        }
        return Fib[number];
    }
}
