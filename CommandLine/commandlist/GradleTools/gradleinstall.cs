using AutoSettings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoSettings;

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

            var client = new HttpClient();
            // client.PutAsync()
        }
    }

    public string gradlew()
    {
        Program program = new Program();
        return program.Gradle = "https://github.com/gradle/gradle/releases/latest";
    }
     
    public static async Task DownloadGradleTools(string[] args)
    {
        Program p1 = new Program();
        commands commands = new commands();
        gradleinstall gradleinstall = new gradleinstall();
        //string Gradlew
        //byte[] GradlewPath = commands.Gradle_path();


        //await File.WriteAllBytesAsync(Gradlew, GradlewPath);
    }



    public static void InstallGradle()
    {
        Program program = new Program();
        commands cmd = new commands();
    }


    public string GradlePATH = "C:\\Windows\\Program Files\\installs\\Gradle\\";
    public string PATH = "C:\\Windows\\Program Files\\installs\\";
    public string TempFilePath = "%localappdata%\\Temp";



}
