using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    // going to put all the derived classes in the same file because they're very small operations
    public interface IRobotCommand
    {
       void Run(Robot robot);
    }

    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
        public override string ToString() => "On";
    }
    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
        public override string ToString() => "Off";
    }

    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) robot.Y++;
        }
        public override string ToString() => "North";
    }
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) robot.Y--;
        }
        public override string ToString() => "South";
    }
    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) robot.X--;
        }
        public override string ToString() => "West";
    }
    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
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
