using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    // going to put all the derived classes in the same file because they're very small operations
    public abstract class RobotCommand
    {
        public abstract void Run(Robot robot);
    }

    public class OnCommand() : RobotCommand()
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
        public override string ToString() => "On";
    }
    public class OffCommand() : RobotCommand()
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
        public override string ToString() => "Off";
    }

    public class NorthCommand() : RobotCommand()
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered) robot.Y++;
        }
        public override string ToString() => "North";
    }
    public class SouthCommand() : RobotCommand()
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered) robot.Y--;
        }
        public override string ToString() => "South";
    }
    public class WestCommand() : RobotCommand()
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered) robot.X--;
        }
        public override string ToString() => "West";
    }
    public class EastCommand() : RobotCommand()
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered) robot.X++;
        }
        public override string ToString() => "East";
    }

    public enum Commands
    {
        On,
        Off,
        North,
        South,
        East,
        West,
        None
    }
}
