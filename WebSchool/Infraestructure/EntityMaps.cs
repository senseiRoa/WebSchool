﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebSchool.Infraestructure.Entities;

namespace WebSchool.Infraestructure
{
    public class T_Course_Map : EntityTypeConfiguration<T_Course>
    {
        public T_Course_Map()
        {
            ToTable("T_Course", "dbo");
        }
    }
    public class T_InscriptionStudent_Map : EntityTypeConfiguration<T_InscriptionStudent>
    {
        public T_InscriptionStudent_Map()
        {
            ToTable("T_InscriptionStudent", "dbo");
        }
    }
    public class T_InstanceOfCourse_Map : EntityTypeConfiguration<T_InstanceOfCourse>
    {
        public T_InstanceOfCourse_Map()
        {
            ToTable("T_InstanceOfCourse", "dbo");
        }
    }
    public class T_School_Map : EntityTypeConfiguration<T_School>
    {
        public T_School_Map()
        {
            ToTable("T_School", "dbo");
        }
    }

    public class T_Menu_Map : EntityTypeConfiguration<T_Menu>
    {
        public T_Menu_Map()
        {
            ToTable("T_Menu", "dbo");
        }
    }

    public class T_Permission_Map : EntityTypeConfiguration<T_Permission>
    {
        public T_Permission_Map()
        {
            ToTable("T_Permission", "dbo");
        }
    }
}