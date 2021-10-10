using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp5
{
    public class Client
    {
        private string name;
        public string Name { get; set; }
        public Client() { }
        public Client(string name)
        {
            this.name = name;
            Name = name;
        }
        public override string ToString()
        {
            return "clientName:" + name;
        }
    }
}
