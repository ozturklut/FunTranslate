using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configurations;

namespace Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TranslateRequest>? TranslateRequests { get; set; }
        public DbSet<TranslateResponse>? TranslateResponses { get; set; }
        public DbSet<RequestUrl>? RequestUrls { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TranslateRequestConfiguration());
            modelBuilder.ApplyConfiguration(new TranslateResponseConfiguration());
            modelBuilder.ApplyConfiguration(new RequestUrlConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

