using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCTDevOpsInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://en.wikipedia.org/wiki/Uniform_Resource_Identifier#Examples";

            string scheme = UriParser.GetScheme(url);
            Console.WriteLine($"Scheme: {scheme}");

            string host = UriParser.GetHost(url);
            Console.WriteLine($"Host: {host}");

            string port = UriParser.GetPort(url);
            Console.WriteLine($"Port: {port}");

            string query = UriParser.GetQuery(url);
            Console.WriteLine($"Query: {query}");

            string fragement = UriParser.GetFragment(url);
            Console.WriteLine($"Fragment: {fragement}");

            Console.ReadLine();
        }

        
    }
}
