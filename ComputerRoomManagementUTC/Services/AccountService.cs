using Common.Common;
using ComputerRoomManagement.Models.Account;
using ComputerRoomManagementUTC.BUS;
using ComputerRoomManagementUTC.Models.User;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRoomManagementUTC.Services
{
    public class AccountService
    {
        public string CreateToken()
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("hasagidzoooooooooo"));
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256),
                Expires = DateTime.UtcNow.AddDays(3)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateJwtSecurityToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
        public bool IsAuthenticate(Login login)
        {
            UserBusiness userBusiness = new UserBusiness();
            var result = userBusiness.GetUserByUserName(login);
            // Get the value of the "HashedPassword" column in db"
            var storageHashedPasswod = result.Item.HashedPassword;

            // Split the salt from "HashedPassword" column in database"
            var salt = SplitSaltFromPasswordCol(storageHashedPasswod);

            // Hash the password from user input and concat it with salt
            string hashedPassword = Hash(login.Password, salt);
            string saltString = Convert.ToBase64String(salt);
            var inputPassword = hashedPassword + " : " + saltString;
            if (inputPassword == storageHashedPasswod)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private byte[] SplitSaltFromPasswordCol(string hashedPassword)
        {
            var saltString = hashedPassword.Split(" : ")[1];
            byte[] salt = Convert.FromBase64String(saltString);
            return salt;
        }

        private string Hash(string password, byte[] salt)
        {
            string hashedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashedPassword;
        }
    }
}
