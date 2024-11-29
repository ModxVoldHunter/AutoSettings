using Microsoft.VisualBasic;
using System.Net;

namespace AutoSettings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string gradlew = program.Gradle = "https://github.com/gradle/gradle/releases/latest";
            string GradlePATH = "C:\\Windows\\Program Files\\installs\\Gradle\\";
            string PATH = "C:\\Windows\\Program Files\\installs\\";
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
                File.Create(GradlePATH);
            }
            else if (File.Exists(PATH))
            {
                File.Create(GradlePATH);
            }
            
            if (File.Exists(PATH))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(gradlew, GradlePATH);
            }
        }
            
            

        public string? Gradle { get; set; }
    }
}
