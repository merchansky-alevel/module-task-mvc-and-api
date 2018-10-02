using AUdependencies.Models;
using System.Collections.Generic;

namespace AUdependencies.Services
{
    public interface IServerService
    {
        void Add(Server server);

        void Update(Server server);

        void Delete(int id);

        Server Get(int id);

        IEnumerable<Server> GetAll();
    }
}
