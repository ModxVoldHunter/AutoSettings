using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoSettings.CommandLine.commands
{
    internal class gradleinstall
    {
        public static void main(string[] args)
        {

            gradleinstall gradleinstall = new gradleinstall();
            if (!File.Exists(gradleinstall.PATH))
            {
                File.Create(gradleinstall.PATH);
                File.Create(gradleinstall.GradlePATH);
            }

            // if the path does exist it will contiune and create a gradle path
            else if (File.Exists(gradleinstall.PATH))
            {
                File.Create(gradleinstall.GradlePATH);
            }

            // if the path exists it will then attempt to download gradle
            if (File.Exists(gradleinstall.PATH))
            {
                
                WebClient webClient = new WebClient();
                webClient.DownloadFile(Convert.ToString(commands.gradlew), gradleinstall.GradlePATH);
            }


            public static void InstallGradle() { }
        
            public string GradlePATH = "C:\\Windows\\Program Files\\installs\\Gradle\\";
            public string PATH = "C:\\Windows\\Program Files\\installs\\";
    }
}
