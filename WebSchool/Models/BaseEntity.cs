﻿using System;

namespace WebSchool.Models
{
    public abstract class BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public DateTime? EraseDate { get; set; }
        public bool LogicalErasure { get; set; }
    }
}