using AutoSettings.CommandLine.commands;
using Microsoft.VisualBasic;
using System.Net;

namespace AutoSettings
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
        }
        public static void Gradletools()
        {
            Program program = new Program();
        }
        public string? Gradle { get; set; }

        public string Name = "AutoSettings";
        public string Version = "1.0.0";
        private static object args;

        public string gradlew(){
            Program program = new Program();
            return program.Gradle = "https://github.com/gradle/gradle/releases/latest";
        }

        public static void Commands(string[] args) {

            Program program = new Program();
            commands.writecmd

            if (args.Length == 0)
            {
                Console.WriteLine("No command-line arguments provided.");
                return;
            }

            switch (args[0])
            {
                case "gradleinstall":
                    if (args.Length > 1)
                    {
                        Console.WriteLine($"installing Gradle");
                        gradleinstall();
                    }
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
