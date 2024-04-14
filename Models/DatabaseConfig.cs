using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class DatabaseConfig
{
    // Static property to store and access the connection string
    public static string ConnectionString { get; } = "Server=localhost;Database=DemoDB;Trusted_Connection=True;";
}
