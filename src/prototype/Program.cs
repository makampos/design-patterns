﻿using prototype;

public class Program
{
    public static void Main(string[] args)
    {
        var jhon = new Person(new [] {$"Jhon", $"Smith"},
            new Address("London Road", 123));
        var jane = new Person(jhon);
        jane.Address.HouseNumber = 155;
        
        Console.WriteLine(jhon);
        Console.WriteLine(jane);
    }
}