class Fibonacci
{

    public int fib1=0, fib2=1, fib3,sum=1;
    public void FibAverage()
    {
        Console.WriteLine("Fib serisinin uzunlugunu girin: ");
        int count = Convert.ToInt32(Console.ReadLine());
        for(int i=2 ; i < count; i++)
        {
            fib3 = fib1 + fib2;
            fib1 = fib2;
            fib2 = fib3;

            sum += fib3;
            Console.WriteLine(fib3);
        }
        
        Console.WriteLine("Serinin ortalaması: {0}",sum/count);
    }

}