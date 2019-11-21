using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperCollections.Properties;

namespace DeveloperCollections.DataAccess
{
    interface IDataConnection
    {
        Developer AddDeveloper(Developer developer);

        List<Developer> GetDevelopers();
        
    }
}
