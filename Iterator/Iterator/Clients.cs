using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Clients
    {
        private List<Client> _clients = new List<Client>();

        public ConcreteIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return this._clients.Count; }
        }

        public Client this[int index]
        {
            get { return _clients[index]; }
            set { _clients.Insert(index, value as Client); }
        }


    }
}
