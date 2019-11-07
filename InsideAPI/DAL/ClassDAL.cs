using Common.Common;
using Common.Entity.Models.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace InsideAPI.DAL
{
    public class ClassDAL
    {
        public ReturnResult<Class> GetAllClassSearched(BaseCondition<Class> condition)
        {
            List<Class> mouseList = new List<Class>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<Class> storedProcedureConfigs = new StoredProcedureConfigs<Class>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_PAGING_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("FROM_RECORD", SqlDbType.Int, condition.FROM_RECORD, ParameterDirection.Input)
                .SetParameter("PAGE_SIZE", SqlDbType.Int, condition.PAGE_SIZE, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 4000, ParameterDirection.Output)
                .SetParameter("OUT_TOTAL_ROWS", SqlDbType.Int, DBNull.Value, ParameterDirection.Output)
                .GetList<Class>(out mouseList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage)
                       .GetOutValue("OUT_TOTAL_ROWS", out totalRows);
            return new ReturnResult<Class>()
            {
                ItemList = mouseList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Class> Edit(ClassEditViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Class> storedProcedureConfigs = new StoredProcedureConfigs<Class>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, mouse.Pk_id, 100, ParameterDirection.Input)
                .SetParameter("Name", SqlDbType.NVarChar, mouse.Name, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, mouse.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, mouse.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Class>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Class> Delete(ClassDeleteViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Class> storedProcedureConfigs = new StoredProcedureConfigs<Class>();
            dbProvider.SetQuery(storedProcedureConfigs._DELETE_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, mouse.Id, ParameterDirection.Input)
                .SetParameter("UserName", SqlDbType.NVarChar, mouse.DeletedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Class>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Class> GetById(int id)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            Class mouse = null;
            StoredProcedureConfigs<Class> storedProcedureConfigs = new StoredProcedureConfigs<Class>();
            dbProvider.SetQuery(storedProcedureConfigs._GET_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.Int, id, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<Class>(out mouse)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Class>()
            {
                Item = mouse,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Class> Add(AddClassViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Class> storedProcedureConfigs = new StoredProcedureConfigs<Class>();
            dbProvider.SetQuery(storedProcedureConfigs._INSERT_SINGLE_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Name", SqlDbType.NVarChar, mouse.Name, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, mouse.Status, ParameterDirection.Input)
                .SetParameter("CreatedBy", SqlDbType.NVarChar, mouse.CreatedBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Class>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }

        public ReturnResult<Class> GetAll()
        {
            List<Class> mouseList = new List<Class>();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;

            dbProvider.SetQuery("MOUSE_GET_ALL", CommandType.StoredProcedure)
                .SetParameter("ERROR_CODE", System.Data.SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", System.Data.SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetList<Class>(out mouseList)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Class>()
            {
                ItemList = mouseList,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }

        public ReturnResult<Class> EditStatus(ClassEditStatusViewModel mouse)
        {
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            StoredProcedureConfigs<Class> storedProcedureConfigs = new StoredProcedureConfigs<Class>();
            dbProvider.SetQuery(storedProcedureConfigs._UPDATE_STATUS_STORED_PROCEDURE, CommandType.StoredProcedure)
                .SetParameter("Id", SqlDbType.NVarChar, mouse.Id, 100, ParameterDirection.Input)
                .SetParameter("Status", SqlDbType.Int, mouse.Status, ParameterDirection.Input)
                .SetParameter("EditBy", SqlDbType.NVarChar, mouse.EditBy, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .ExcuteNonQuery()
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<Class>()
            {
                ErrorCode = outCode,
                ErrorMessage = outMessage,
            };
        }
    }
}
