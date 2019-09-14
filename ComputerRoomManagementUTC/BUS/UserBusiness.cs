using Common.Common;
using ComputerRoomManagement.Models.Account;
using ComputerRoomManagementUTC.DAL;
using ComputerRoomManagementUTC.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagementUTC.BUS
{
    public class UserBusiness
    {
        private UserDAL _userDAL { get; set; }
        public UserDAL UserDAL
        {
            get
            {
                return _userDAL = new UserDAL(); ;
            }
        }
        public ReturnResult<User> GetUserByUserName(Login login)
        {
            return UserDAL.GetUserByUserName(login);
        }
    }
}
