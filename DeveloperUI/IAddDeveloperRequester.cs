using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeveloperCollections;

namespace DeveloperUI
{
    public interface IAddDeveloperRequester
    {
        void DeveloperComplete(Developer developer);
    }
}
