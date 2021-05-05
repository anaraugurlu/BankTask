using System;
using ClientNamespace;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNamespace
{
   
    
    public    class Bank
        {
            public Client[] Clients { get; set; }
            public int ClientCount { get; set; }


            public int[] Remove(int index)
            {
                int[] destination = new int[Clients.Length - 1];
                if (index > 0)
                {
                    Array.Copy(Clients, 0, destination, 0, index);
                }
                if (index < Clients.Length - 1)
                {
                    Array.Copy(Clients, index + 1, destination, index, Clients.Length - index - 1);
                }
                return destination;
            }
            public void AddClient(ref Client client)
            {
                Client[] temp = new Client[++ClientCount];
                if (Clients != null)
                {
                    Clients.CopyTo(temp, 0);
                }
                temp[temp.Length - 1] = client;
                Clients = temp;
            }
            public void Show()
            {
                if (Clients != null)
                {
                    foreach (var item in Clients)
                    {
                        item.Bankcard.Show();
                    }
                }
            }
        }
    
}
