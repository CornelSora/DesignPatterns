﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Model
{
    interface IClientRepository : IDisposable
    {
        IEnumerable<Client> GetClients();
        Client GetClientById(int clientId);
        void InsertClient(Client client);
        void DeleteClient(int clientId);
        void UpdateClient(Client client);
        void Save();
    }
}
