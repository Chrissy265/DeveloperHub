using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperCollections.DataAccess;

namespace DeveloperCollections
{
  public static  class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            switch(db)
            {
                case DatabaseType.Sql:
                    break;
                case DatabaseType.TextFile:
                    break;

                default:
                    break; 
            }


            //Connection to database later on 

            //public static string CnnString(string name) //go to the AppConfig and get the connection string name
            //{
            //    return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            //}
        }
    }
}
