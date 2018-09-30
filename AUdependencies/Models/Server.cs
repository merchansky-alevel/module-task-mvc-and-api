using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUdependencies.Models
{
    public class Server
    {
        public int Id { get; set; }
        public string Domen { get; set; }
        public string Name { get; set; }
        public ServerType Type { get; set; }
    }

    public enum ServerType
    {
        Web = 1,
        Gaming,
        Media,
        Email,
        Users,
    }
}
