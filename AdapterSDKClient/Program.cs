using NSwagDemo.Services;
using System;

namespace AdapterSDKClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileClient obj = new FileClient();
            obj.GetFileListAsync("DirectoryName");

            WeatherForecastClient objClient = new WeatherForecastClient();
            objClient.GetCoolestStateAsync();

            Console.WriteLine("Hello World!");
        }
    }
}
