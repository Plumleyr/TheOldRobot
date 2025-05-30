﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public class Robot(int x, int y, bool isPowered)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
        public bool IsPowered { get; set; } = isPowered;

        public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
        public void Run()
        {
            foreach (IRobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }
}
