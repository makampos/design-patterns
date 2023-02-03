﻿using singleton.PerThreadSingleton;

public static class Program
{
    public static void Main(string[] args)
    {
        var t1 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("T1" + PerThreadSingleton.Instance.Id);
        });

        var t2 = Task.Factory.StartNew(() =>
        {
            Console.WriteLine("T2" + PerThreadSingleton.Instance.Id);
            Console.WriteLine("T3" + PerThreadSingleton.Instance.Id);
        });

        Task.WaitAll(t1, t2);
    }
}