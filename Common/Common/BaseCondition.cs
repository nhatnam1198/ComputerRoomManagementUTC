using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Common
{
    public class BaseCondition<T>
    {
        public int PAGE_INDEX { get; set; }
        public int PAGE_SIZE { get; set; }
        public int FROM_RECORD => PAGE_SIZE * (PAGE_INDEX - 1);
        public string IN_WHERE { get; set; }
        public string IN_SORT { get; set; }
        T Item { get; set; }
    }
}
