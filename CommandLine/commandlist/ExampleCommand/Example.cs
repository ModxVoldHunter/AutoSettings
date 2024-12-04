using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSettings;

internal class Example
{
    public static void ExampleCommand(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No command-line arguments provided.");
            return;
        }

        switch (args[0])
        {
            case "Example":
                if (args.Length > 1)
                {
                    Console.WriteLine("This an Example");
                }
                else
                {
                    Console.WriteLine("Error Example lol");
                }
                break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
        switch (args[0])
        {
            case "--Install":
                Console.WriteLine("Must provide another argument, use --help for more info");
                return;
            case "--help":
                Console.WriteLine("Command list");
                Console.WriteLine("--install | installs tools (usage: AutoSettings --install \"name\"");
                Console.WriteLine("Page 1/1");
                return;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
    }
}
