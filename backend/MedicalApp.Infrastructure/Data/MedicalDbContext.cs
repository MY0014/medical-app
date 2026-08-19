using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Infrastructure.Data
{
    internal class MedicalDbContext : DbContext
    {
        public MedicalDbContext(DbContextOptions<MedicalDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
