using System;

namespace AwsDotnetCsharp
{
    public class LocalCore
    {
        public static void Main()
        {
            string content = FtpUtil.Download();
            Console.WriteLine(content);
        }
    }
}
