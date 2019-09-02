using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Common
{
    public class ReturnResult<T>
    {
        public string ErrorMessage { get; set; }
        public string ErrorCode { get; set; }
        public T Item { get; set; }
        public List<T> ItemList { get; set; }
        public bool HasData
        {
            get
            {
                return Item == null || Item == null;
            }
        }

        public bool HasError
        {
            get
            {
                return string.IsNullOrEmpty(ErrorCode) && ErrorCode != "0";
            }
        }

        public int TotalRows { get; set; }
    }
}
