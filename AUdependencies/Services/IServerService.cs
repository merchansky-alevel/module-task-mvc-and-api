using AUdependencies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUdependencies.Services
{
    public interface IServerService
    {
        Server Get(int id);
        void Add();
        void Update(Server server);
        void Delete(int id);
    }
}
