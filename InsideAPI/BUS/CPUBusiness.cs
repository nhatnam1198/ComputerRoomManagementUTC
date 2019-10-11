using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.BUS
{
    public class CPUBusiness
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

        public ReturnResult<RAM> AddRam(AddRamViewModel ram)
        {
            return RamDAL.Add(ram);
        }

        public ReturnResult<RAM> GetById(int Id)
        {
            return RamDAL.GetById(Id);
        }

        public ReturnResult<RAM> Delete(RamDeleteViewModel ram)
        {
            return RamDAL.Delete(ram);
        }

        public ReturnResult<RAM> Edit(RamEditViewModel ram)
        {
            return RamDAL.Edit(ram);
        }

        public ReturnResult<RAM> EditStatus(RamEditStatusViewModel ram)
        {
            return RamDAL.EditStatus(ram);
        }
    }
}
