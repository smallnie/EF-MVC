﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using efef.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace efef.DAL
{
    public class AccountContext:DbContext
    {
        public AccountContext() : base("AccountContext")
        { }

        public DbSet<SysUser> SysUsers { get; set; }

        public DbSet<SysRole> SysRoles { get; set; }

        public DbSet<SysUserRole> SysUserRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove <PluralizingTableNameConvention>();
        }
    }
}