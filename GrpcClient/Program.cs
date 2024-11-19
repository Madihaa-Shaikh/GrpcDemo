using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient
{
     class Program
    {
           static async Task Main (string[] args) {
            var input = new HelloRequest { Name = "Tim" };
            var channel = GrpcChannel.ForAddress("https://127.0.0.1:7224");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(input);
            Console.WriteLine(reply.Message);
            Console.ReadLine();

        }
    }
}
