using MicroFocus.FAS.AdapterSdk.RestAdapter.Client;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace AdapterSDKClient
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            execute();

            Console.WriteLine("Hello World!");
        }

        private static async void execute()
        {
            try
            {
                WeatherForecastClient objClient = new WeatherForecastClient("http://localhost:50937/");
                var coolResult = await objClient.GetCoolestStateAsync().ConfigureAwait(false);
                var hotResult = await objClient.GetHottestStateAsync().ConfigureAwait(false);

                FileClient obj = new FileClient("http://localhost:50937/");
                var response = await obj.GetFileListAsync("DirectoryName").ConfigureAwait(false);

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
