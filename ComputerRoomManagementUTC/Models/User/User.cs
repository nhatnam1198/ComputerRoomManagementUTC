﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagementUTC.Models.User
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string HashedPassword { get; set; }
        public int PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
        public string Title { get; set; }
    }
}
