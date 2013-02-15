using System;
using System.Net;
//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

class Program
{
    static void Main(string[] args)
    {
        using (System.Net.WebClient webClient = new System.Net.WebClient())
        {
            try
            {
                // Downloads the resource with the specified URI to a local file.
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "./Logo-BASD.jpg");

                Console.WriteLine("Download is OK.");
            }
            //catch (WebException ex)
            //{
            //    Console.WriteLine("Exception caught in process: {0}", ex.ToString());
            //}
            //catch (NotSupportedException ex)
            //{
            //    Console.WriteLine("Exception caught in process: {0}", ex.ToString());
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Download is NOT OK!");
                Console.WriteLine(ex);
            }
        } // "using" -  free all resources here .
    }
}

