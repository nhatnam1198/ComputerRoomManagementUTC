using Common.Common;
using Common.Entity.Models.Account;
using Common.Entity.Models.User;
using InsideAPI.DAL;

namespace InsideAPI.BUS
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
