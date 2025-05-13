using TheOldRobot;

Robot robot = new(0, 0, false);

Commands[] commands = (Commands[])Enum.GetValues(typeof(Commands));

List<RobotCommand> commandMethods =
[
    new OnCommand(),
    new OffCommand(),
    new NorthCommand(),
    new SouthCommand(),
    new EastCommand(),
    new WestCommand()
];


int commandsGiven = 0;

while(commandsGiven < 3)
{
    Console.WriteLine($"You've given your robot {commandsGiven} / 3 commands. Give your robot {3 - commandsGiven} more commands.");

    for (int i = 0; i < commands.Length; i++)
    {
        Console.WriteLine($"{i}: {commands[i]}");
    }

    string? choice;
    bool isValid = false;
    do
    {
        Console.WriteLine($"Enter a number from 0 to {commands.Length - 1}");
        choice = Console.ReadLine();
        if (int.TryParse(choice, out int input) && input >= 0 && input < commands.Length)
        {
            if (commands[input].ToString() == "None")
            {
                robot.Commands[commandsGiven] = null;
                commandsGiven++;
                isValid = true;
            }
            else
            {
                foreach (RobotCommand command in commandMethods)
                {
                    if (commands[input].ToString() == command.ToString())
                    {
                        robot.Commands[commandsGiven] = command;
                        commandsGiven++;
                        isValid = true;
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid input");
        }
    } while (!isValid);
}

robot.Run();