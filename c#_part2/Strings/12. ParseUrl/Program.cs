using System;
using System.Text.RegularExpressions;
//Write a program that parses an URL address given in the format:
//		and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//		[protocol] = "http"
//		[server] = "www.devbg.org"
//		[resource] = "/forum/index.php"

class Program
{
    static void Main(string[] args)
    {
        string url = "http://www.devbg.org/forum/index.php";

        string protocol;
        string server;
        string resource;
        try
        {
            ParseUrl(url, out protocol, out server, out resource);
            Console.WriteLine("[protocol] = \"{0}\"\n[server] = \"{1}\"\n[resource] = \"{2}\"", protocol, server, resource);

            ParseUrl2(url, ref protocol, ref server, ref resource);
            Console.WriteLine("Secong Method:");
            Console.WriteLine("[protocol] = \"{0}\"\n[server] = \"{1}\"\n[resource] = \"{2}\"", protocol, server, resource);

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
        }
    }

    private static void ParseUrl2(string url, ref string protocol, ref string server, ref string resource)
    {
        //Extract protocol
        int indexProtocol = url.IndexOf("://");

        if (indexProtocol == -1)
        {
            indexProtocol = -3;  // No protocol -> skip
        }
        else
        {
            protocol = url.Substring(0, indexProtocol);
        }

        //extract server
        int indexServer = url.IndexOf('/', indexProtocol + 3);

        if (indexServer == -1)
        {
            throw new FormatException("URL format is wrong!");
        }

        server = url.Substring(indexProtocol + 3, indexServer - indexProtocol - 3);

        //extract resource
        resource = url.Substring(indexServer);
    }

    private static void ParseUrl(string url, out string protocol, out string server, out string resource)
    {
        //string regexPattern = @"^(?<protocol>[^:/\?#]+)://(?<server>[^/\?#]*)?(?<resource>[^\?#]*)";
        string regexPattern = @"((?<protocol>[^:/\?#]+)://)*(?<server>.*?)(?<resource>/.*)";

        Regex regEx = new Regex(regexPattern);
        Match maches = regEx.Match(url);

        protocol = maches.Groups["protocol"].Value;
        server = maches.Groups["server"].Value;
        resource = maches.Groups["resource"].Value;

        if (server == "")
        {
            throw new FormatException("URL format is wrong!");
        }
    }
}

