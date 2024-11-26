using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. ArrayList - Insert() 
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Insert(1, 99);  // Insert 1
        Console.WriteLine("ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        arrayList.RemoveAt(2);  // washla 2
        Console.WriteLine();

        // 2. List - AddRange() da Sort() metodebi
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.AddRange(new int[] { 5, 15, 25 });  // AddRange elementebis damateba
        list.Sort();  
        Console.WriteLine("List:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.RemoveAt(3);  // waSla 3
        Console.WriteLine();

        // 3. Dictionary - Keys da Values 
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        Console.WriteLine("Dictionary (Keys and Values):");
        foreach (var key in dictionary.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {dictionary[key]}");
        }
        dictionary.Remove(2);  //washla 2
        Console.WriteLine();

        // 4. SortedList - RemoveAt() da Values[index] metodebi
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");
        Console.WriteLine("SortedList (Values[index]):");
        Console.WriteLine(sortedList[2]);  // amoReba indeqsiT
        sortedList.RemoveAt(1);  // waSla indeqsi 1
        foreach (var item in sortedList)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
        Console.WriteLine();

        // 5. Stack - Peek() metodi
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Stack (Peek):");
        Console.WriteLine(stack.Peek());  // Peek bolo elementi
        stack.Pop();  // waSla bolo elementi
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // 6. Queue - Peek() meTodi
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Queue (Peek):");
        Console.WriteLine(queue.Peek());  // Peek pirveli elementi
        queue.Dequeue();  // waSla pirveli elementi
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // 7. SortedDictionary - Keys / Values 
        SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
        sortedDictionary.Add(1, "Apple");
        sortedDictionary.Add(2, "Banana");
        sortedDictionary.Add(3, "Cherry");
        Console.WriteLine("SortedDictionary (Keys and Values):");
        foreach (var key in sortedDictionary.Keys)
        {
            Console.WriteLine($"Key: {key}, Value: {sortedDictionary[key]}");
        }
        sortedDictionary.Remove(2);  // waSla 2
        Console.WriteLine();

        // 8. HashSet - UnionWith() 
        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        hashSet.Add(2);  // dublikati ver daemateba
        Console.WriteLine("HashSet (UnionWith):");
        hashSet.UnionWith(new HashSet<int> { 4, 5 });
        foreach (var item in hashSet)
        {
            Console.WriteLine(item);
        }
    }
}

