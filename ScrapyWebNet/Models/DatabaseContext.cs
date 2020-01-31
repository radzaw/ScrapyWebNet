﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Node> Nodes { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
        }
    }
}
