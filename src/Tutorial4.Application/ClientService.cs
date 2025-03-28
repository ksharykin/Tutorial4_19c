using Tutorial4.Models;

namespace Tutorial4.Application;

public class ClientService
{
    private List<Client> _clients;

    public ClientService()
    {
        _clients = new List<Client>()
        {
            new Client()
            {
                Name = "Alice Brown",
                Balance = 6000.23m
            },
            new Client()
            {
                Name = "Bob Brown",
                Balance = 3412.01m
            },
            new Client()
            {
                Name = "Charlie Miller",
                Balance = 2368.33m
            }
        };
    }
}