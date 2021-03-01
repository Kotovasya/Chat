using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ServiceReference;

namespace ConsoleClient.Callbacks
{
    public partial class CallbackService
    {
        internal Model model;
        public AuthServiceClient authService;
        public MessagingServiceClient messagingService;

        public CallbackService()
        {
            model = new Model();
            authService = new AuthServiceClient(new System.ServiceModel.InstanceContext(this));
            messagingService = new MessagingServiceClient(new System.ServiceModel.InstanceContext(this));
        }
    }
}
