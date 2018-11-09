﻿using System;

namespace LastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong[] a = new ulong[n + 1];
            a[0] = 0;
            a[1] = 1;
            for (ulong i = 2; i <= n; i++)
            {
                ulong c = a[i - 2] / 10;
                ulong d = a[i - 1] / 10;
                a[i - 2] -= c * 10;
                a[i - 1] -= d * 10;
                a[i] = a[i - 1] + a[i - 2];
                ulong e = a[i] / 10;
                a[i] -= e * 10;
            }
            Console.Write(a[n]);
            Console.Read();
        }
    }
}
