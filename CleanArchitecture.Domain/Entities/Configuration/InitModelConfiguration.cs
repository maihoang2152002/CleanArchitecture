using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Domain.Entities.Configuration
{
    public class InitModelConfiguration : IEntityTypeConfiguration<InitModel>
    {
        public void Configure(EntityTypeBuilder<InitModel> builder)
        {
            builder.HasData(new InitModel { Id = Guid.NewGuid(), InitModelName = "System Design By Paritosh Gupta" },
                            new InitModel { Id = Guid.NewGuid(), InitModelName = "Two States By Chetan Bhagat" },
                            new InitModel { Id = Guid.NewGuid(), InitModelName = "Harry Potter and the Philosopher Stone by J.K. Rowling" },
                            new InitModel { Id = Guid.NewGuid(), InitModelName = "IQOO Z6" },
                            new InitModel { Id = Guid.NewGuid(), InitModelName = "Samsung Galaxy Tab A9+" },
                            new InitModel { Id = Guid.NewGuid(), InitModelName = "Fossil Gen 6 Digital Black Dial Men's Watch-FTW4061" },
                            new InitModel { Id = Guid.NewGuid(), InitModelName = "Fastrack New Limitless FS1 Smart Watch" }
                );
        }
    }
}
