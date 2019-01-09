using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace AwsDotnetCsharp
{
    public class FTPDownload
    {
      public APIGatewayProxyResponse Download(APIGatewayProxyRequest request, ILambdaContext context)
        {
          // Log entries show up in CloudWatch
          Console.WriteLine("Another example\n");
          Console.WriteLine(JsonConvert.SerializeObject(request.Body));
          string content = FtpUtil.Download();
          var response = new APIGatewayProxyResponse
          {
              StatusCode = (int)HttpStatusCode.OK,
              Body = content,
              Headers = new Dictionary<string, string> {{ "Content-Type", "application/json" }}
          };

          return response;
      }
    }
}
