﻿using System;

namespace ClassMethod
{
    class Vehicle
    {
        public string color;
        public int NoOfWheels;
    
    }

    class Method
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.color = "red";
            v.NoOfWheels = 4;

            Vehicle v2 = new Vehicle();
            v2.color = "yellow";
            v2.NoOfWheels = 2;

            Console.WriteLine(v.color);
            Console.WriteLine(v2.no);
        }
    }
}