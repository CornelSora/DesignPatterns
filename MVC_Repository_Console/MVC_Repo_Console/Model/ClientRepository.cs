using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Model
{
    class ClientRepository : IClientRepository
    {
        List<Client> _clients = new List<Client>();
        private string _filePath;

        public ClientRepository(string filePath)
        {
            _filePath = filePath;
            LoadInMemory();
        }

        public void DeleteClient(int clientId)
        {
            _clients.RemoveAll(x => x.Id == clientId);
        }

        public void Dispose()
        {
            File.Delete(_filePath);
        }

        public Client GetClientById(int clientId)
        {
            return _clients.FirstOrDefault(x => x.Id == clientId);
        }

        public IEnumerable<Client> GetClients()
        {
            return _clients;
        }

        public void InsertClient(Client client)
        {
            _clients.Add(client);
        }

        public void Save()
        {
            WriteFile();
        }

        public void UpdateClient(Client client)
        {
            var oldClient = _clients.FirstOrDefault(x => x.Id == client.Id);
            if (oldClient == null)
            {
                _clients.Add(client);
            }
            else
            {
                oldClient.Name = client.Name;
                oldClient.Age = client.Age;
            }
        }

        private void LoadInMemory()
        {
            if (!File.Exists(_filePath))
            {
                var fileStream = File.Create(_filePath);
                fileStream.Close();
            }

            List<string> lines = File.ReadLines(_filePath).ToList();
            foreach (var line in lines)
            {
                string[] data = line.Split(',');
                Int32.TryParse(data[0], out int id);
                string name = data[1];
                Int32.TryParse(data[2], out int age);
                Client client = new Client()
                {
                    Id = id,
                    Name = name,
                    Age = age
                };
                _clients.Add(client);
            }
        }

        private void WriteFile()
        {
            List<string> lines = new List<string>();
            foreach (var client in _clients)
            {
                lines.Add(string.Format("{0},{1},{2}", client.Id, client.Name, client.Age));
            }
            File.WriteAllLines(_filePath, lines.ToArray());
        }
    }
}
