using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleClient.ServiceReference;

namespace ConsoleClient.Callbacks
{
    public partial class CallbackService : IServiceCallback
    {
        internal Model model;
        internal ServiceClient service;

        public CallbackService()
        {
            service = new ServiceClient(new System.ServiceModel.InstanceContext(this));
            model = new Model();
        }
    }
}
