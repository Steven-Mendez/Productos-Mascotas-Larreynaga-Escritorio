using System.Configuration;

namespace DataLayer
{
    public static class DataConnection
    {
        public static string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["PPMLDB"].ConnectionString;
    }
}