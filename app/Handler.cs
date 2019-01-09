using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Net;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AwsDotnetCsharp
{
    public class Handler
    {
      public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request, ILambdaContext context)
        {
          // Log entries show up in CloudWatch
          context.Logger.LogLine("Example log entry\n");

          var response = new APIGatewayProxyResponse
          {
              StatusCode = (int)HttpStatusCode.OK,
              Body = "{ \"Message\": \"Hello World\" }",
              Headers = new Dictionary<string, string> {{ "Content-Type", "application/json" }}
          };

          return response;
      }
    }
}
