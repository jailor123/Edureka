using System;
class overload {
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
 
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }
 
    public static void Main(String[] args)
    {
      overload ob = new overload();
 
        int sum1 = ob.Add(1, 2);
        Console.WriteLine("sum of the two "
                          + "integer value : " + sum1);
 
        int sum2 = ob.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                          + "integer value : " + sum2);
    }
}
