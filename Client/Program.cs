﻿using Client.Model;
using Client.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientModel model = new ClientModel();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthWindow(model));
        }
    }
}
