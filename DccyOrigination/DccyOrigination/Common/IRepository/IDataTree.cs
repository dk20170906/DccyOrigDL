using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccyOrigination.Common.IRepository
{
  public  interface IDataTree<T> 
    {
        /// <summary>
        /// 得到泛型的树行集合
        /// </summary>
        /// <returns></returns>
        List<T> GetTreeList(List<T>list);
        /// <summary>
        /// 得到string的树型集合
        /// </summary>
        /// <returns></returns>
        List<string> GetEntityKeyStringTreeList(List<string>list);
        /// <summary>
        /// 得到int树型集合
        /// </summary>
        /// <returns></returns>
        List<int> GetEntityKeyIntTreeList(List<int>list);
    }
}
