﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSchool.Models
{
    public class PersonViewModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
    }
}