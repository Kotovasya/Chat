﻿using Client.Binding;
using Client.Entities;
using Client.ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Model
{
    public class ClientModel : ServiceClient
    {
        private static readonly ClientCallbacks instance = new ClientCallbacks();
        public SourceList<long, Entities.Message> Messages { get; private set; }
        public SourceList<Guid, User> Users { get; private set; }

        public Guid Id { get; set; }

        public ClientModel() 
            : base(new InstanceContext(instance))
        {
            instance.Model = this;
            Messages = new SourceList<long, Entities.Message>();
            Users = new SourceList<Guid, User>();
            try
            {
                Id = Connect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ошибка подключения к серверу, пожалуйста, попробуй позже", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
