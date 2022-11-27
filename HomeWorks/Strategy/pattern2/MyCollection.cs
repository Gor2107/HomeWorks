using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.pattern2
{
    internal class MyCollection
    {
        public int[] Collection { get; set; } = { 3,4,7,1,2,3,46,-7};
        private ISortable SortMethod { get; init; }
        public MyCollection(ISortable sortStrategy)
        {
            this.SortMethod = sortStrategy;
        }
      public void Sort()
        {
            SortMethod.Sort(Collection);
        }
    }
}
