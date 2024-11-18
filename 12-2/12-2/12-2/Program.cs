
public static class Utility
{
    // generikuli metodi, romelic paraetrad igebs List<T> da abrunebs elementebis raodenobas
    public static int GetCount<T>(List<T> list)
    {
        return list.Count;
    }
}

public class Program
{
    public static void Main()
    {
        //  List<int> 
        List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 9 };
        Console.WriteLine("List<int> count: " + Utility.GetCount(intList)); 

        //  List<string> 
        List<string> stringList = new List<string> { "natia", "vakho", "beka" ,"mariami"};
        Console.WriteLine("List<string> count: " + Utility.GetCount(stringList)); 
    }
}
