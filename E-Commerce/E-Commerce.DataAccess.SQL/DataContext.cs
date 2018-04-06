﻿using E_Commerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccess.SQL {
    public class DataContext : DbContext {
        public DataContext() : base("DefaultConnection") { 

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductsCategories { get; set; }
    }
}
