using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Amazon.Lambda.DynamoDBEvents;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace AwsDotnetCsharp
{
    public class Dynamo
    {
        public void Update(DynamoDBEvent request, ILambdaContext context)
        {
            string content = JsonConvert.SerializeObject(request.Records);
            // Log entries show up in CloudWatch
            Console.WriteLine("Dynamo Example\n");
            Console.WriteLine(content);
           
        }
    }
}
