using System;
using Common.Common;
using Common.Entity.Models.RAM;
using InsideAPI.DAL;

namespace InsideAPI.BUS
{
    public class RamBusiness
    {
        private RamDAL _ramDAL;
        public RamDAL RamDAL
        {
            get
            {
                _ramDAL = new RamDAL();
                return _ramDAL;
            }
        }
        public ReturnResult<RAM> GetAllRamSearched(BaseCondition<RAM> condition)
        {
            RamDAL ramDAL = new RamDAL();
            var result = ramDAL.GetAllRamSearched(condition);
            return result;
        }

        public ReturnResult<RAM> GetAll()
        {
            return RamDAL.GetAll();
        }

        public ReturnResult<RAM> AddRam(RAM ram)
        {
            return RamDAL.Add(ram);
        }
    }
}
