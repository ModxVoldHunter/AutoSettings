using AutoSettings;
using Microsoft.VisualBasic;
using System.Net;

namespace AutoSettings;

internal class Program
{

    static void Main(string[] args)
    {
        Program program = new Program();
        Commands(args);
    }
    public static void Gradletools()
    {
        Program program = new Program();
    }
    public string? Gradle { get; set; }

    public string Name = "AutoSettings";
    public string Version = "1.0.0";
    private static object args;



    public static void Commands(string[] args) {

        Program program = new Program();
        gradleinstall gradleinstall = new gradleinstall();
        

        if (args.Length == 0)
        {
            Console.WriteLine("No command-line arguments provided.");
            return;
        }

        switch (args[1])
        {
            case "gradleinstall":
                if (args.Length > 1)
                {
                    gradleinstall gradleinstall1 = new gradleinstall();
                    Console.WriteLine($"installing Gradle");
                    //gradleinstall.DownloadGradleTools();
                }
                break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
        switch (args[0])
        {
            case "Example":
                if (args.Length > 1)
                {
                    Example.ExampleCommand(args);
                }
                break;
            default:
                Console.WriteLine("Unknown command.");
                break;
        }
    }
}
