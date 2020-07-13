using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Options
    {
        public class DatabaseOptions
        {
            public string ConnectionString { get; set; }
            public int MaxConnections { get; set; }
        }
    }
}
