using DccyOrigination.Common.IRepository;
using DccyOrigination.Models.SysManagement;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DccyOrigination.Common.Repository
{
    public class DataTree<T> : IDataTree<T>
    {
        public List<int> GetEntityKeyIntTreeList(List<int> list)
        {
            throw new NotImplementedException();
        }

        public List<string> GetEntityKeyStringTreeList(List<string> list)
        {
            throw new NotImplementedException();
        }

        public List<T> GetTreeList(List<T> list)
        {
            throw new NotImplementedException();
        }
    }
}
