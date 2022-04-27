using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veresiye.Core.DataAccess
{
    public class VeresiyeDatabase
    {
        public static readonly string connectionString = new FbConnectionStringBuilder
        {
            Database = "veresiye.fdb",
            ServerType = FbServerType.Embedded,
            UserID = "SYSDBA",
            Password = "masterkey",
            ClientLibrary = "fbclient.dll"
        }.ToString();
    }
}
