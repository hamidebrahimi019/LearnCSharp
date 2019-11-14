using System;
public class SingleTon
{
    private static SingleTon _singleTon;
    private SingleTon() 
    {
    }

    public int CalculatePow(int number)
    {
        return number * number;
    }

    public static SingleTon GrtInstance()
    {
        if(_singleTon == null)
            _singleTon = new SingleTon();
        return _singleTon;
    }
}

class Program
{
    static void Main()
    {
        SingleTon testSingleTon = SingleTon.GrtInstance();
        Console.WriteLine(testSingleTon.CalculatePow(4));
    }
}