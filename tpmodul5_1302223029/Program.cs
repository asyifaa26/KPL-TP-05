using System;
public class HaloGeneric
{
    public void SapaUser<x>(x nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: {0}", data);
    }
}

class program
{
    static void Main(string[] args)
    {
        HaloGeneric generic_1302223029 = new HaloGeneric();
        generic_1302223029.SapaUser("Asy-Syifa");

        string nim = "1302223029";
        DataGeneric<String> data = new DataGeneric<string>(nim);
        data.PrintData();
    }
}