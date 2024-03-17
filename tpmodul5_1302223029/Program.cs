using System;
public class HaloGeneric
{
    public void SapaUser<x>(x nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

class program
{
    static void Main(string[] args)
    {
        HaloGeneric generic_1302223029 = new HaloGeneric();
        generic_1302223029.SapaUser("Asy-Syifa");
    }
}