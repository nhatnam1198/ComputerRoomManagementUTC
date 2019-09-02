using Common.Common;
using ComputerRoomManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagement.DAL
{
    public class RamDAL
    {
        public ReturnResult<RAM> GetAllRamSearched(BaseCondition<RAM> condition)
        {
            List<RAM> ramList = new List<RAM>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<RAM> storedProcedureConfigs = new StoredProcedureConfigs<RAM>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_PAGING_STORED_PROCEDURE, System.Data.CommandType.StoredProcedure)
                .SetParameter("FROM_RECORD", System.Data.SqlDbType.Int, condition.FROM_RECORD, System.Data.ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", System.Data.SqlDbType.Int, condition.FROM_RECORD, System.Data.ParameterDirection.Input)
                .GetList<RAM>(out ramList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<RAM>()
            {
                ItemList = ramList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<RAM> GetAll()
        {
            List<RAM> ramList = new List<RAM>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<RAM> storedProcedureConfigs = new StoredProcedureConfigs<RAM>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_ALL_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<RAM>(out ramList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<RAM>()
            {
                ItemList = ramList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
    }
}
