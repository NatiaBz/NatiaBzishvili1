using System;

class Program
{
    // meTodi romelic iTvlis ricxvebis jams moc indeqsze
    static int SumOfDigitsAtIndex(int[] array, int index)
    {
        // Tu indeqsi ar aris amsivis Signit, vabrunebT -1
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("arasworia indeqsi.");
            return -1;  
        }

        //iRebs masividan ricxvis mocemuli indeqsidan
        int number = array[index];

        // cvladi cifrebis jamis Sesanaxad
        int sum = 0;

        // cifrebis jamis gamotvla
        while (number > 0)
        {
            sum += number % 10;  // ricxvis bolo cifris damateba jamSi
            number /= 10;  // bolo cifris waSla
        }

        return sum;  // dabruneba cifrebis jamis
    }

    static void Main()
    {
        
        Console.Write("SeiyvaneT masivis elementebis raodenoba: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"SeiyvaneT elementi {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

       
        Console.Write("SeiyvaneT indeqsi: ");
        int index = int.Parse(Console.ReadLine());

        int result = SumOfDigitsAtIndex(array, index);

      
        if (result != -1)
        {
            Console.WriteLine($"indeqsze {index} jami: {result}");
        }
    }
}
