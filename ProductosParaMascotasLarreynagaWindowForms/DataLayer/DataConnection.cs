using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class DataConnection
    {
        public static string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["PPMLDB"].ConnectionString;
    }
}
