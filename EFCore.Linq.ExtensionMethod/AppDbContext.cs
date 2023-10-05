﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Linq.ExtensionMethod
{
    internal class AppDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

    }
}
