using System;
using System.IO;
using System.Net;
using System.Web;

namespace AwsDotnetCsharp
{
    public static class FtpUtil
    {
        public static string Download ()
        {
            Console.WriteLine(Environment.GetEnvironmentVariable("FTP_USER"));
            // Get the object used to communicate with the server.
            string encoded = HttpUtility.UrlEncode("test.txt");
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://13.251.156.227/" + encoded);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(Environment.GetEnvironmentVariable("FTP_USER"), Environment.GetEnvironmentVariable("FTP_PW"));

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string content = reader.ReadToEnd();

            Console.WriteLine($"Download Complete, status {response.StatusDescription}");

            reader.Close();
            response.Close();
            return content;
        }
    }
}