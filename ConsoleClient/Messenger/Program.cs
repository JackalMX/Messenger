﻿using System;

namespace Messenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            Console.WriteLine("Начало");
            Console.WriteLine(msg.ToString());
        }
    }
}
