using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repository
{
    public class CleanArchitectureDbContext : DbContext
    {
        private readonly ILogger<CleanArchitectureDbContext> _logger;
        public CleanArchitectureDbContext(DbContextOptions options, ILogger<CleanArchitectureDbContext> logger) : base(options)
        {
            _logger = logger;
        }

        public DbSet<InitModel> InitModel { get; set; }

        protected override void OnModelCreating(ModelBuilder InitModelBuilder)
        {
            InitModelBuilder.ApplyConfiguration(new InitModelConfiguration());
        }
    }
}
