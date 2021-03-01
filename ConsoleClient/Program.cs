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
            CallbackService service = new CallbackService();
            service.model.Id = service.authService.Connect();
            string line = Console.ReadLine();
            service.authService.Authorization(new AuthRequest() { Id = service.model.Id, Login = line, Password = line });
            var response = service.messagingService.SendMessage(new SendMessageRequest() { Id = service.model.Id, Text = "Hello!" });
            Console.WriteLine(response.Result);
            Console.ReadLine();
        }
    }
}
