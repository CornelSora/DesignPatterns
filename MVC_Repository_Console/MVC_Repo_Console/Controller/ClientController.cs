using PregatireExamen.Model;
using PregatireExamen.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PregatireExamen.Controller
{
    class ClientController
    {
        private Client _clientModel;
        private ClientView _clientView;
        private ClientRepository _repository;

        public ClientController()
        {
            _clientModel = new Client();
            _clientView = new ClientView();
            _repository = new ClientRepository("./clients.txt");

            _clientView.CommandSelected += new EventHandler(CommandSelected);
            _clientView.IdSelected += new EventHandler(ClientSelected);
            _clientView.IdRemoved += new EventHandler(ClientRemoved);
        }

        private void ClientRemoved(object sender, EventArgs e)
        {
            string idS = (string)sender;
            int id = Int32.Parse(idS.Trim());
            _repository.DeleteClient(id);
            _clientView.DisplayDeleteDoneWithSuccess();
        }

        private void ClientSelected(object sender, EventArgs e)
        {
            string idS = (string)sender;
            int id = Int32.Parse(idS.Trim());
            var client = _repository.GetClientById(id);
            _clientView.DisplayClientDetails(string.Format("{0},{1},{2}", client.Id, client.Name, client.Age));
        }

        private void CommandSelected(object sender, EventArgs e)
        {
            string cmd = (string)sender;
            switch (cmd)
            {
                case "1":
                    List<Client> clients = _repository.GetClients().ToList();
                    string clientsString = "";
                    for (int i = 0; i < clients.Count; i++)
                    {
                        clientsString += string.Format("{0},{1},{2}\n", clients[i].Id, clients[i].Name, clients[i].Age);
                    }
                    _clientView.DisplayListOfClients(clientsString);
                    break;
                case "2":
                    _clientView.DisplayMessageForSelect();
                    break;
                case "3":
                    _clientView.DisplayMessageForRemove();
                    break;
                case "4":
                    _repository.Save();
                    _clientView.DisplaySuccessSave();
                    break;
                case "x":
                    _clientView.Close();
                    break;
                case "X":
                    _clientView.Close();
                    break;
                default:
                    break;
            }
        }

        public void DisplayClientView()
        {
            _clientView.OpenFirstMessage();
        }


    }
}
