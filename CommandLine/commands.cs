using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSettings.CommandLine.commands;

internal class commands
{   public commands()
    {
        Program program = new Program();
        commands commands = new commands();
        Console.WriteLine("Welcome to " + program.Name + program.Version);


        }

    public string gradlew()
    {
        Program program = new Program();
        return program.Gradle = "https://github.com/gradle/gradle/releases/latest";
    }
    

    public string GradlePATH = "C:\\Windows\\Program Files\\installs\\Gradle\\";
    public string PATH = "C:\\Windows\\Program Files\\installs\\";


}
