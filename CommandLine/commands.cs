using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSettings;

internal class commands
{   public commands()
    {
        Program program = new Program();
        commands commands = new commands();
        Console.WriteLine("Welcome to " + program.Name + program.Version);
     }


    public static byte[] Gradle_path()
    {
        gradleinstall gradleinstall = new gradleinstall();
        return Encoding.UTF8.GetBytes(gradleinstall.GradlePATH);
    }
}
