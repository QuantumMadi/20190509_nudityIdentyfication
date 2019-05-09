using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeepAI;

namespace DeepAi.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            DeepAI_API api = new DeepAI_API(apiKey: "c374d52f-84ce-46a6-8a4f-598ba5b9e988");
            StandardApiResponse resp = api.callStandardApi("nsfw-detector", new
            {
                image = File.OpenRead(@"C:\Users\www\Desktop\1\sasha2.jpg"),
            });
            Console.WriteLine(api.objectAsJsonString(resp));
            Console.ReadLine();
        }
    }
}
