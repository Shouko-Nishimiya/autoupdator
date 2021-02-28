using System;
using Leaf.xNet;
using System.Threading;
using System.Net;

namespace Updater
{
      class Program
      {
              static void Main(string[] args)
             {
                     string currentVersion = "v1.0";
                     var VersionCheck = new HttpRequest();
                     string get = VersionCheck.Get("").ToString(); //tutorial make a account on pastebin.com create a paste called version type program version save it and put url in here

                     if(get != currentVersion)
                     {
                     Console.WriteLine("Downloading Update...");
                     Thread.Sleep(1000);

                     var client = new WebClient();
                     client.DownloadFile("Download Url of your updated file", "YourAppName.exe");

                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine($"Succesfully downloaded update {get}");
                     Console.ReadKey();
                     }
             }
      }
}
