using ConsoleClient.Callbacks;
using ConsoleClient.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CallbackService callbackService = new CallbackService();
            callbackService.model.Id = callbackService.service.Connect();
            string line = Console.ReadLine();
            var authRsponse = callbackService.service.Authorization(new AuthRequest() { Id = callbackService.model.Id, Login = line, Password = line });
            if (authRsponse.Result == Result.Succesfully)
                callbackService.model.Id = authRsponse.Id;
            var response = callbackService.service.SendMessage(new SendMessageRequest() { Id = callbackService.model.Id, Text = "Hello!" });
            Console.WriteLine(response.Result);
            Console.ReadLine();
        }
    }
}
