public class Counter
{
    // veli romelic inaxavs obieqtebsi raodnobas
    private static int count = 0;

    // konstruqtori romelic rdis count-s
    public Counter()
    {
        count++;
    }

    // Static meTodi romelic abrunebs count-s
    public static int GetCount()
    {
        return count;
    }

    // reset 0-ze
    public static void ResetCount()
    {
        count = 0;
    }
}

public class Program
{
    public static void Main()
    {
        //axali counter obieqtis Seqmna
        Counter c1 = new Counter();
        Console.WriteLine("Current count: " + Counter.GetCount()); // 1

        Counter c2 = new Counter();
        Console.WriteLine("Current count: " + Counter.GetCount()); // 2

        Counter c3 = new Counter();
        Console.WriteLine("Current count: " + Counter.GetCount()); // 3

        // ResetCount() 0-ze dayeneba
        Counter.ResetCount();
        Console.WriteLine("Current count after reset: " + Counter.GetCount()); // 0
    }
}
