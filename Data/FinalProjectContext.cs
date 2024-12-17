﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject.Models.Listing> Listing { get; set; } = default!;
        public DbSet<FinalProject.Models.EventItem> EventItem { get; set; } = default!;
        public DbSet<FinalProject.Models.Shelter> Shelter { get; set; } = default!;
    }
}
