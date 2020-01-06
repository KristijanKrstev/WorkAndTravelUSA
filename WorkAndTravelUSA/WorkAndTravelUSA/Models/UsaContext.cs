﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WorkAndTravelUSA.Models
{
    public class UsaContext:DbContext
    {
        public DbSet<Client> clientModels { get; set; }
        public DbSet<Location> locationModels { get; set; }
        public DbSet<Comment> commentModels { get; set; }
        public DbSet<ClientLoc> clientLocModels { get; set; }

        public UsaContext():base("DefaultConnection")
        {

        }

    }
}