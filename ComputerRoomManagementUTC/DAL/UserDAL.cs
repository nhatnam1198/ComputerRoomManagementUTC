﻿using Common.Common;
using ComputerRoomManagement.DAL;
using ComputerRoomManagement.Models;
using ComputerRoomManagement.Models.Account;
using ComputerRoomManagementUTC.Models.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagementUTC.DAL
{
    public class UserDAL
    {
        public ReturnResult<User> GetUserByUserName(Login login)
        {
            User user = new User();
            DbProvider dbProvider = new DbProvider();
            string outCode = String.Empty;
            string outMessage = String.Empty;
            int totalRows = 0;
            StoredProcedureConfigs<User> storedProcedureConfigs = new StoredProcedureConfigs<User>();
            dbProvider.SetQuery("GET_USER_BY_USER_NAME", CommandType.StoredProcedure)
                .SetParameter("UserName", SqlDbType.NVarChar, login.UserName, 50, ParameterDirection.Input)
                .SetParameter("ERROR_CODE", SqlDbType.NVarChar, DBNull.Value, 100, ParameterDirection.Output)
                .SetParameter("ERROR_MESSAGE", SqlDbType.NVarChar, DBNull.Value, 400, ParameterDirection.Output)
                .GetSingle<User>(out user)
                .Complete();
            dbProvider.GetOutValue("ERROR_CODE", out outCode)
                       .GetOutValue("ERROR_MESSAGE", out outMessage);
            return new ReturnResult<User>()
            {
                Item = user,
                ErrorCode = outCode,
                ErrorMessage = outMessage,
                TotalRows = totalRows
            };
        }
    }
}
