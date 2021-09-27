﻿using System;

namespace LinecComputationuc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line comparison computation");

            double line1, line2;
            Program p = new Program();
            p.takeCartesiaPoint();
            line1 = p.computeDistance();
            Console.WriteLine("Line distance is " + line1);

            p.takeCartesiaPoint();
            line2 = p.computeDistance();
            Console.WriteLine("Line distance is " + line2);

            Console.WriteLine(p.DisplayLinesRelation(line1, line2));
        }
    }
}
