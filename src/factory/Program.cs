﻿namespace factory;

public class Program
{
    public static void Main(string[] args)
    {
        var point = Point.NewPolarPoint(1.0, Math.PI / 2);
        Console.WriteLine(point);
    }
}