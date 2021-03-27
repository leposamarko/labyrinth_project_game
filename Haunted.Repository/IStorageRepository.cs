using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Haunted.Repository
{
    interface IStorageRepository
    {
        public void GetData(XDocument data);
    }
}
