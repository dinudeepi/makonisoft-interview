﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakoniSoft.Models
{
    public class UserViewModel
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName},{LastName}";
            }
        }
    }
}
