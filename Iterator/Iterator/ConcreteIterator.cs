using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class ConcreteIterator : AIterator
    {
        private Clients _clients;
        private int _position = 0;

        public ConcreteIterator(Clients clients)
        {
            _clients = clients;
        }

        public override Client CurrentItem()
        {
            if (_position >= _clients.Count || _position < 0)
            {
                return null;
            }
            return _clients[_position];
        }

        public override Client First()
        {
            _position = 0;
            return _clients[_position];
        }

        public override bool IsDone()
        {
            return _clients.Count == _position || _position < 0;
        }

        public override void Next()
        {
            if (_position <= _clients.Count - 1)
            {
                _position++;
            }
        }

        public override Client Last()
        {
            _position = _clients.Count - 1;
            return _clients[_position];
        }

        public override void Prev()
        {
            if (_position >= 0)
            {
                _position--;
            }
        }

    }
}
