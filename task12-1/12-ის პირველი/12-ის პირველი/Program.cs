using System;

public class Box<T>
{
    // private field, T Senaxva
    private T _value;

    // setvalue
    public void SetValue(T value)
    {
        _value = value;
    }

    // getvalue
    public T GetValue()
    {
        return _value;
    }
}

public class Program
{
    public static void Main()
    {
        // Box<int> 
        Box<int> intBox = new Box<int>();
        intBox.SetValue(39);
        Console.WriteLine("Box<int> value: " + intBox.GetValue());

        // Box<string> 
        Box<string> stringBox = new Box<string>();
        stringBox.SetValue("Natia, Bzishvili");
        Console.WriteLine("Box<string> value: " + stringBox.GetValue()); 

        // Box<double> 
        Box<double> doubleBox = new Box<double>();
        doubleBox.SetValue(2.09);
        Console.WriteLine("Box<double> value: " + doubleBox.GetValue()); 
    }
}
