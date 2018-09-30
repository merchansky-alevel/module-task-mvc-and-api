using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUdependencies.Context;
using AUdependencies.Models;

namespace AUdependencies.Services
{
    class ServerService : IServerService
    {
        ApplicationContext db = new ApplicationContext();

        public void Add(Server server)
        {
            db.Servers.Add(server);
        }

        public void Delete(int id)
        {
            db.Servers.Remove(Get(id));
        }

        public Server Get(int id)
        {
            return db.Servers.FirstOrDefault(z => z.Id == id);
        }

        public void Update(Server server)
        {
            var oldServer = db.Servers.FirstOrDefault(z => z.Id == server.Id);
            oldServer.Domen = server.Domen;
            oldServer.Name = server.Name;
            oldServer.Type = server.Type;
        }
    }
}
